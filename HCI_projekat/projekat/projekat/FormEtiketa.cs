using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace projekat
{
    public partial class FormEtiketa : Form
    {
        private Regex rx_id = null;
       // private Regex rx_opis = null;

        private bool formIsValid = true;
        Dictionary<object, bool> errorRepeat = new Dictionary<object, bool>();
        Vrsta vrsta = null;//kojoj vrsti pripada data etiketa

        public FormEtiketa()
        {
            InitializeComponent();
			this.CenterToParent();
            Tabelarni_prikaz_etikete.koZoveDodaj = "dodaj";
            rx_id = new Regex("^\\w+$");
            //rx_opis = new Regex("^\\w+$");
            errorRepeat.Add(textBoxIdE, false);
            errorRepeat.Add(textBoxOpisE, false);
        }
        public FormEtiketa(Vrsta v)//konstruktor sa imenom vrste da bismo znali u koju listu dodati etiketu
        {                                   //pozivan iz tabele vrsta
            InitializeComponent();
			this.CenterToParent();
            this.vrsta = v;
            Tabelarni_prikaz_etikete.koZoveDodaj = "dodaj";
            rx_id = new Regex("^\\w+$");
            //rx_opis = new Regex("^\\w+$");
            errorRepeat.Add(textBoxIdE, false);
            errorRepeat.Add(textBoxOpisE, false);
        }
        public FormEtiketa(Etiketa e,Vrsta vrsta)
        {
            InitializeComponent();
			this.CenterToParent();
			this.vrsta = vrsta;
            rx_id = new Regex("^\\w+$");
            //rx_opis = new Regex("^\\w+$");
            errorRepeat.Add(textBoxIdE, false);
            errorRepeat.Add(textBoxOpisE, false);
            this.Text = "Izmjena etikete";
            textBoxIdE.Text = e.ID;
            textBoxIdE.ReadOnly = true;//ako je izmjeni da ne moze mijenjati id
            textBoxBoja.BackColor = e.Boja;
            textBoxOpisE.Text = e.Opis;
            
        }

        private void FormEtiketa_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timUnosE_Tick(object sender, EventArgs e)
        {
            labelErrorE.Visible = false;
            timUnosE.Stop();
        }

        private void textBoxIdE_Validating(object sender, CancelEventArgs e)
        {
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (rx_id.Match(textBoxIdE.Text).Success)
            {
                epUnosE.SetError(textBoxIdE, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                epUnosE.SetError(textBoxIdE, "Id netačno formatirano ili nije uneto.");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }
        }

        private void buttonDodajE_Click(object sender, EventArgs e)
        {
            if (Tabelarni_prikaz_etikete.koZoveDodaj.Equals("dodaj"))
            {
                provjeraPriDodavanju();
                Tabelarni_prikaz_tipa.koZoveDodaj = "dodaj";
            }
            else if (Tabelarni_prikaz_etikete.koZoveDodaj.Equals("izmjeni"))
            {
                provjeraPriIzmjeni();
                Tabelarni_prikaz_vrste.koZoveDodaj = "izmjeni";
            }
        }
        public void provjeraPriIzmjeni()
        {
            formIsValid = true;
            this.ValidateChildren();
            if (formIsValid)
            {
                this.DialogResult = DialogResult.OK;
                String ID = textBoxIdE.Text;
                Color boja = textBoxBoja.BackColor;

                String opis = textBoxOpisE.Text;
               // Etiketa e = new Etiketa(ID, boja, opis);

                //izbrisemo onu etiketu koja vec postoji sa tim id-em
                List<Etiketa> etikete = Tabelarni_prikaz_etikete.etikete;
				int index = 0;
                for (int i = 0; i < etikete.Count; i++)
                {
                    if (etikete[i].ID.Equals(ID))
                    {
						etikete[i].Boja = boja;
						etikete[i].Opis = opis;
						index = i;
                        break;
                    }
                }

				if (vrsta == null)
				{
					Console.WriteLine("Nema vrstu");
					vrsta = etikete[index].vrsta;
				}
             
				
               //dodavanje etikete u listu etiketa u vrsti
       
                for (int i = 0; i < vrsta.etikete.Count; i++)
                {
                    if ((vrsta.etikete[i]).ID.Equals(ID))
                    {
						(vrsta.etikete[i]).Boja = boja;
						(vrsta.etikete[i]).Opis = opis;
                        break;
                    }
                }
                

                this.Close();
            }
            else
            {
                labelErrorE.Text = "Unos nemoguć. \nPostoje greške.";
                labelErrorE.Visible = true;
                timUnosE.Start();
            }
        }
        public void provjeraPriDodavanju()
        {
            String postoji = "ne postoji";//flag da li postoji vrsta sa takvim id-om
            String ID = textBoxIdE.Text;
            foreach (Etiketa e in Tabelarni_prikaz_etikete.etikete)
            {
                if (ID.Equals(e.ID))
                {
                    postoji = "postoji";

                    MessageBox.Show("ID mora biti jednistven!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (postoji.Equals("postoji")) return;

            formIsValid = true;
            this.ValidateChildren();
            if (formIsValid)
            {

                this.DialogResult = DialogResult.OK;

                Color boja = textBoxBoja.BackColor;

                String opis = textBoxOpisE.Text;
                Etiketa e = new Etiketa(ID, boja, opis);
				e.vrsta = vrsta;
                vrsta.etikete.Add(e);//u listu etiketa date vrste dodajemo novu etiketu
				
                (Tabelarni_prikaz_etikete.etikete).Add(e);//dodate su u listu svih etiketa svih vrstu
                
                Console.WriteLine("Dodao u etikete! Ima ih:" + Tabelarni_prikaz_etikete.etikete.Count);

                this.Close();
            }
            else
            {
                labelErrorE.Text = "Unos nemoguć. \nPostoje greške.";
                labelErrorE.Visible = true;
                timUnosE.Start();
            }
        }

        private void buttonBoja_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();//omogucava otvaranje dialoga za biranje boje textBox-a
            textBoxBoja.BackColor = colorDialog1.Color;
        }

        private void textBoxOpisE_Validating_1(object sender, CancelEventArgs e)
        {
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (textBoxOpisE.Text.Trim() != "")
            {
                epUnosE.SetError(textBoxOpisE, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                epUnosE.SetError(textBoxOpisE, "Opis nije unijet.");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
    }
}
