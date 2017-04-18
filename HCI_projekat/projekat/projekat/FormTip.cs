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
    public partial class FormTip : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        private Regex rx_id = null;
        private Regex rx_ime = null;
		private formMain main = null;

        private bool formIsValid = true;
        Dictionary<object, bool> errorRepeat = new Dictionary<object, bool>();
		private Tip tip = null;
		private String textPolja = "";
		private int brojac = 0; 

        public FormTip(formMain main)
        {
            InitializeComponent();
			this.CenterToParent();
			this.main = main;
            Tabelarni_prikaz_tipa.koZoveDodaj = "dodaj";
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            rx_id = new Regex("^\\w+$");
            rx_ime = new Regex("^\\w+$");
 

            errorRepeat.Add(textBoxImeT, false);
            errorRepeat.Add(textBoxIdT, false);
            errorRepeat.Add(textBoxOpisT, false);
            errorRepeat.Add(pictureBoxTip, false);
        }
        public FormTip(Tip t,formMain main)
        {
            InitializeComponent();
			this.main = main;
			this.tip = t;
			this.CenterToParent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            rx_id = new Regex("^\\w+$");
            rx_ime = new Regex("^\\w+$");

            errorRepeat.Add(textBoxImeT, false);
            errorRepeat.Add(textBoxIdT, false);
            errorRepeat.Add(textBoxOpisT, false);
            errorRepeat.Add(pictureBoxTip, false);
            this.Text = "Izmjena tipa";
            textBoxIdT.Text = t.ID;
            textBoxIdT.ReadOnly = true;//ako je izmjeni da ne moze mijenjati id
            textBoxImeT.Text = t.Ime;
            textBoxOpisT.Text = t.Opis;
            pictureBoxTip.BackgroundImage = t.Img;
            


        }
		
		public void postaviKursor()
		{
		//	Point controlLoc = this.PointToScreen(textBoxIdT.Location);
		//	Point pozicijaKursora = new Point(controlLoc.X + textBoxIdT.Size.Width - 10, controlLoc.Y + textBoxIdT.Size.Height / 2);
		//	Cursor.Position = pozicijaKursora;
			upisiOznaku();
		}
		public void upisiOznaku()
		{
			textPolja = "JedinstvenaOznaka";
			textBoxIdT.Text += textPolja[brojac];
			timerPopuni.Start();
		}
		public void upisiNaziv()
		{
			textPolja = "Ime";
			textBoxImeT.Text += textPolja[brojac];
			timerNaziv.Start();
		}
		public void upisiOpis()
		{
			textPolja = "Opisuj.";
			textBoxOpisT.Text += textPolja[brojac];
			timerUpisiOpis.Start();
		}
		private void timerPopuni_Tick(object sender, EventArgs e)
		{

			brojac++;
			timerPopuni.Stop();

			if (brojac < textPolja.Length)
				upisiOznaku();
			else
			{
				brojac = 0;
				textBoxImeT.Select();
				//prebaci kursor na naziv
			//	Point controlLoc = this.PointToScreen(textBoxImeT.Location);
			//	Point pozicijaKursora = new Point(Cursor.Position.X, Cursor.Position.Y + textBoxImeT.Location.Y / 2);
			//	Cursor.Position = pozicijaKursora;
				upisiNaziv();
			}
		}
		private void timerNaziv_Tick(object sender, EventArgs e)
		{
			brojac++;
			timerNaziv.Stop();

			if (brojac < textPolja.Length)
				upisiNaziv();
			else
			{
				brojac = 0;
				textBoxOpisT.Select();
				//prebaci kursor na naziv
			//	Point controlLoc = this.PointToScreen(textBoxOpisT.Location);
			//	Point pozicijaKursora = new Point(Cursor.Position.X, Cursor.Position.Y + textBoxOpisT.Location.Y / 2);
			//	Cursor.Position = pozicijaKursora;
				upisiOpis();
			}
		}
		private void timerUpisiOpis_Tick(object sender, EventArgs e)
		{
			brojac++;
			timerUpisiOpis.Stop();

			if (brojac < textPolja.Length)
				upisiOpis();

			else
			{
				brojac = 0;

				//pomeri kurosor na dugme sacuvaj podatke
			//	Point controlLoc = this.PointToScreen(buttonDodajT.Location);
			///	Point pozicijaKursora = new Point(controlLoc.X + buttonDodajT.Size.Width / 2, controlLoc.Y + buttonDodajT.Size.Height / 2);
			//	Cursor.Position = pozicijaKursora;

				timerSacuvajTip.Start();

			}
		}
		private void timerSacuvajTip_Tick(object sender, EventArgs e)
		{
			buttonDodajT_Click(this, EventArgs.Empty);
			timerSacuvajTip.Stop();
			
		}
        private void buttonUcitaj_Click(object sender, EventArgs e)
        {
            DialogResult d = ofd.ShowDialog();
            if (d == DialogResult.OK)
            {
                string fname = ofd.FileName;
                Image img = new Bitmap(fname);
                img = new Bitmap(img, new Size(pictureBoxTip.Width, pictureBoxTip.Height));
                pictureBoxTip.BackgroundImage = img;
                
            }
        }



        private void buttonDodajT_Click(object sender, EventArgs e)
        {
			if (textBoxIdT.Text.Equals("JedinstvenaOznaka"))
			{
				this.Close();
				main.PonoviDemo();
				return;
			}
            if (Tabelarni_prikaz_tipa.koZoveDodaj.Equals("dodaj"))
            {
                provjeraPriDodavanju();
                Tabelarni_prikaz_tipa.koZoveDodaj = "dodaj";
            }
            else if (Tabelarni_prikaz_tipa.koZoveDodaj.Equals("izmjeni"))
            {
                provjeraPriIzmjeni();
                Tabelarni_prikaz_vrste.koZoveDodaj = "izmjeni";
            }
          
        }
        public void provjeraPriIzmjeni()
        {
            formIsValid = true;
            this.ValidateChildren();
            if (pictureBoxTip.BackgroundImage == null)
            {
                epUnosT.SetError(pictureBoxTip, "Ikonica nije odabrana!");
                formIsValid = false;
            }
            if (formIsValid)
            {
                this.DialogResult = DialogResult.OK;
                String ID = textBoxIdT.Text;
                String ime = textBoxImeT.Text;
                
                String opis = textBoxOpisT.Text;
                
                Image img = pictureBoxTip.BackgroundImage;
                //izbrisemo onu vrstu koja vec postoji sa tim id-em
                List<Tip> tipovi = Tabelarni_prikaz_tipa.tipovi;
                int index = 0;

				if(tip == null)
					Console.WriteLine("Nema tipa!");
				String ime_id = tip.Ime+" "+tip.ID;//ime i id prije izmjene
                for (int i = 0; i < tipovi.Count; i++)
                {
                    if (tipovi[i].ID.Equals(tip.ID))
                    {
						tipovi[i].Ime = ime;
						tipovi[i].Opis = opis;
						tipovi[i].Img = img;
						index = i;
                        break;
                    }
                }
				for (int i = 0; i < tipovi[index].vrste.Count; i++)
				{
					tipovi[index].vrste[i].Tip = tipovi[index].Ime + " " + tipovi[index].ID;
				}

				for (int i = 0; i < Tabelarni_prikaz_vrste.vrste.Count; i++)
				{
					//ime_id = tipovi[index].Ime+" "+tipovi[index].ID;
					if (ime_id.Equals(Tabelarni_prikaz_vrste.vrste[i].Tip))
					{
						Tabelarni_prikaz_vrste.vrste[i].Tip = tipovi[index].Ime + " " + tipovi[index].ID;
					}
				}
                this.Close();
            }
            else
            {
                labelErrorT.Text = "Unos nemoguć. \nPostoje greške.";
                labelErrorT.Visible = true;
                timUnosT.Start();
            }
        }
        public void provjeraPriDodavanju()
        {
            String postoji = "ne postoji";//flag da li postoji vrsta sa takvim id-om
            String ID = textBoxIdT.Text;
            foreach (Tip t in Tabelarni_prikaz_tipa.tipovi)
            {
                if (ID.Equals(t.ID))
                {
                    postoji = "postoji";

                    MessageBox.Show("ID mora biti jednistven!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (postoji.Equals("postoji")) return;

            formIsValid = true;
            this.ValidateChildren();
            if (pictureBoxTip.BackgroundImage == null)
            {
                epUnosT.SetError(pictureBoxTip, "Ikonica nije odabrana!");
                formIsValid = false;
            }
            if (formIsValid)
            {

                this.DialogResult = DialogResult.OK;

                String ime = textBoxImeT.Text;
           
                String opis = textBoxOpisT.Text;
                Image img = pictureBoxTip.BackgroundImage;
                Tip tip = new Tip(ID, ime, opis,img);

                (Tabelarni_prikaz_tipa.tipovi).Add(tip);
                Console.WriteLine("Dodao u tipove! Ima ih:" + Tabelarni_prikaz_tipa.tipovi.Count);
                this.Close();
            }
            else
            {
                labelErrorT.Text = "Unos nemoguć. \nPostoje greške.";
                labelErrorT.Visible = true;
                timUnosT.Start();
            }
        }

        private void timUnosT_Tick(object sender, EventArgs e)
        {
            labelErrorT.Visible = false;
            timUnosT.Stop();
        }

        private void textBoxIdT_Validating(object sender, CancelEventArgs e)
        {
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (rx_id.Match(textBoxIdT.Text).Success)
            {
                epUnosT.SetError(textBoxIdT, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                epUnosT.SetError(textBoxIdT, "Id netačno formatirano ili nije uneto.");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }
        }

        private void textBoxImeT_Validating(object sender, CancelEventArgs e)
        {
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (rx_ime.Match(textBoxImeT.Text).Success)
            {
                epUnosT.SetError(textBoxImeT, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                epUnosT.SetError(textBoxImeT, "Ime netačno formatirano ili nije uneto.");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }
        }

        private void textBoxOpisT_Validating_1(object sender, CancelEventArgs e)
        {
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (textBoxOpisT.Text.Trim()!="")
            {
                epUnosT.SetError(textBoxOpisT, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                epUnosT.SetError(textBoxOpisT, "Opis netačno formatirano ili nije uneto.");
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
			if (main.IsDemoMode())
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
				main.NormalanMode();
				return;
			}
			this.Close();
		}

		private void FormTip_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (main.IsDemoMode())
			{
				Console.WriteLine("Pritisnuooooooooooooo");
				this.Close();
				main.NormalanMode();
				return;
			}
		}

		private void FormTip_MouseClick(object sender, MouseEventArgs e)
		{
			if (main.IsDemoMode())
			{
				this.Close();
				main.NormalanMode();
			}
		}

		private void FormTip_Load(object sender, EventArgs e)
		{

		}

		private void FormTip_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (main.IsDemoMode())
			{
				main.NormalanMode();
			}
		}

		private void FormTip_KeyDown(object sender, KeyEventArgs e)
		{

		}



		

		

		
    }
}
