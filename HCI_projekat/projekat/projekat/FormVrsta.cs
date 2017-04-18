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
    public partial class FormVrsta : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        //private Tabelarni_prikaz_vrste tpv = new Tabelarni_prikaz_vrste();
        private String status;//za selektovani status ugrozenosti iz komba
        private Regex rx_id= null;
        private Regex rx_ime = null;
        private Regex rx_prihod = null;
        private bool formIsValid = true;
        Dictionary<object, bool> errorRepeat = new Dictionary<object, bool>();
        private formMain main = null;
		private Vrsta vrsta = null;

        public FormVrsta(formMain main)
        {
            InitializeComponent();
			this.CenterToParent();
            Tabelarni_prikaz_vrste.koZoveDodaj = "dodaj";
            this.main = main;

            foreach(Tip tip in Tabelarni_prikaz_tipa.tipovi)
            {
                comboBoxTip.Items.Add(tip.Ime + " " + tip.ID);
            }

            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            rx_id = new Regex("^\\w+$");
            rx_ime = new Regex("^\\w+$");
            rx_prihod = new Regex("^\\d+$");//prihod je u ciframa

            errorRepeat.Add(textBoxIme, false);
            errorRepeat.Add(textBoxId, false);
            errorRepeat.Add(textBoxOpis, false);
            errorRepeat.Add(comboBoxTip, false);
            errorRepeat.Add(textBoxPrihod, false);
            errorRepeat.Add(comboBoxStatus, false);
            errorRepeat.Add(comboBoxTuristicki, false);
            errorRepeat.Add(pictureBoxVrsta, false);

        }//konstruktor dijaloga za izmjenu
        public FormVrsta(Vrsta v,formMain main)
        {
            InitializeComponent();
			this.CenterToParent();
            this.main = main;
			this.vrsta = v;
            foreach (Tip tip in Tabelarni_prikaz_tipa.tipovi)
            {
                comboBoxTip.Items.Add(tip.Ime+" "+tip.ID);//prikazuje i id jer je to kljuc i trebace mi da bih nasla odgovarajuci tip 
            }                                              //za dodavanje u listu vrsta 
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            rx_id = new Regex("^\\w+$");
            rx_ime = new Regex("^\\w+$");
            //rx_opis = new Regex("^\\w+$");
            rx_prihod = new Regex("^\\d+$");//prihod je u ciframa

            errorRepeat.Add(textBoxIme, false);
            errorRepeat.Add(textBoxId, false);
            errorRepeat.Add(textBoxOpis, false);
            errorRepeat.Add(comboBoxTip, false);
            errorRepeat.Add(textBoxPrihod, false);
            errorRepeat.Add(comboBoxStatus, false);
            errorRepeat.Add(comboBoxTuristicki, false);
            errorRepeat.Add(pictureBoxVrsta, false);

            this.Text = "Izmjena vrste";
            textBoxId.Text = v.ID;
            textBoxId.ReadOnly = true;//ako je izmjeni da ne moze mijenjati id
            textBoxIme.Text = v.Ime;
            textBoxOpis.Text = v.Opis;
            comboBoxTip.SelectedItem = v.Tip;
            comboBoxStatus.SelectedItem = v.StatusUgrozenosti;
            if (v.Opasna.Equals("DA")) checkBoxOpasna.Checked=true;
            if (v.CrvenaLista.Equals("DA")) checkBoxUICN.Checked = true;
            if (v.NaseljeniRegion.Equals("DA")) checkBoxRegion.Checked = true;
            pictureBoxVrsta.BackgroundImage = v.Img;
            comboBoxTuristicki.SelectedItem = v.TuristickiStatus;
            textBoxPrihod.Text = (v.GodisnjiPrihod).ToString();
            String date = v.DatumOtkrivanja;//05-05-1994
            String[] poCrti = date.Split('-');
            dateTimePicker1.Value = new DateTime(Int32.Parse(poCrti[2]), Int32.Parse(poCrti[1]), Int32.Parse(poCrti[0]));//godina,mjesec,dan

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelIme_Click(object sender, EventArgs e)
        {

        }

        private void buttonUcitaj_Click(object sender, EventArgs e)
        {
            DialogResult d = ofd.ShowDialog();
            if (d == DialogResult.OK)
            {
                string fname = ofd.FileName;
                Image img = new Bitmap(fname);
                img = new Bitmap(img, new Size(pictureBoxVrsta.Width, pictureBoxVrsta.Height));
                pictureBoxVrsta.BackgroundImage = img;
            }
        }

        private void textBoxIme_Validating(object sender, CancelEventArgs e)
        {
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (rx_ime.Match(textBoxIme.Text).Success)
            {
                epUnos.SetError(textBoxIme, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                epUnos.SetError(textBoxIme, "Ime netačno formatirano ili nije uneto.");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            //provjera da je pozvano klikom na izmjeni ili na dodaj
            if (Tabelarni_prikaz_vrste.koZoveDodaj.Equals("dodaj"))
            {
                provjeraPriDodavanju();
                Tabelarni_prikaz_vrste.koZoveDodaj = "dodaj";//ako nekoliko puta pogrijesimo prilikom unosa
                                                            //onda ne radi potvrdi jer ne zna da li treba da doda ili da izmjeni
               // main.myImageList.Images.Clear();
                main.refreshTree();
                
            
            }                                               
            else if (Tabelarni_prikaz_vrste.koZoveDodaj.Equals("izmjeni"))
            {
                provjeraPriIzmjeni();
                Tabelarni_prikaz_vrste.koZoveDodaj = "izmjeni";
                main.refreshTree();
                
            }
            
        }
        public void provjeraPriDodavanju()
        {
            String postoji = "ne postoji";//flag da li postoji vrsta sa takvim id-om
            String ID = textBoxId.Text;
            String tip = (String)comboBoxTip.SelectedItem;
            foreach (Vrsta vr in Tabelarni_prikaz_vrste.vrste)
            {
                if (ID.Equals(vr.ID))
                {
                    postoji = "postoji";

                    MessageBox.Show("ID mora biti jednistven!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            if (postoji.Equals("ne postoji"))
            {

                formIsValid = true;
                this.ValidateChildren();
                if (pictureBoxVrsta.BackgroundImage == null)
                {
                    foreach (Tip t in Tabelarni_prikaz_tipa.tipovi)
                    {
                        String tip_id = t.Ime + " " + t.ID;
                        if (tip_id.Equals(tip))
                        {
                            pictureBoxVrsta.BackgroundImage = t.Img;
                            break;
                        }
                    }
                }
                if (formIsValid)
                {

                    this.DialogResult = DialogResult.OK;

                    String ime = textBoxIme.Text;
                    
                    String opis = textBoxOpis.Text;
                    status = (String)comboBoxStatus.SelectedItem;//preuzima koji je selektovan status ugrozenosti
                    //Console.WriteLine(status);
                    String opasna = (checkBoxOpasna.Checked) ? "DA" : "NE";

                    String uicn = (checkBoxUICN.Checked) ? "DA" : "NE";

                    String region = (checkBoxRegion.Checked) ? "DA" : "NE";

                    String tur_status = (String)comboBoxTuristicki.SelectedItem;
                    int prihod = Int32.Parse(textBoxPrihod.Text);
                    string datum = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    Image img = pictureBoxVrsta.BackgroundImage;
					Vrsta v = new Vrsta(ID, ime, opis, tip, status, opasna, uicn, region, tur_status, prihod, datum, img);

					(Tabelarni_prikaz_vrste.vrste).Add(v);
					//dodavanje vrste u listu vrsta odgovarajuce
					String tip_id = tip.Split(' ')[1];
					foreach (Tip t in Tabelarni_prikaz_tipa.tipovi)
					{
						if (t.ID.Equals(tip_id))
						{
							t.vrste.Add(v);
							break;
						}
					}

                    this.Close();
                }
                else
                {
                    labelError.Text = "Unos nemoguć. \nPostoje greške.";
                    labelError.Visible = true;
                    timUnos.Start();
                }
            }
        }
        public void provjeraPriIzmjeni()
        {
           
            formIsValid = true;
            this.ValidateChildren();
            String tip = (String)comboBoxTip.SelectedItem;
            //provjera da li je dodata ikonica
            if (pictureBoxVrsta.BackgroundImage == null)
            {
                foreach (Tip t in Tabelarni_prikaz_tipa.tipovi)
                {
                    String tip_id = t.Ime + " " + t.ID;
                    if (tip_id.Equals(tip))
                    {
                        pictureBoxVrsta.BackgroundImage = t.Img;
                        break;
                    }
                }
            }
            if (formIsValid)
            {
                this.DialogResult = DialogResult.OK;
                String ID = textBoxId.Text;
                String ime = textBoxIme.Text;
               
                String opis = textBoxOpis.Text;
                status = (String)comboBoxStatus.SelectedItem;//preuzima koji je selektovan status ugrozenosti
                //Console.WriteLine(status);
                String opasna = (checkBoxOpasna.Checked) ? "DA" : "NE";

                String uicn = (checkBoxUICN.Checked) ? "DA" : "NE";

                String region = (checkBoxRegion.Checked) ? "DA" : "NE";

                String tur_status = (String)comboBoxTuristicki.SelectedItem;
                int prihod = Int32.Parse(textBoxPrihod.Text);
                string datum = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                Console.WriteLine(opasna);
                Console.WriteLine(uicn);
                Console.WriteLine(region);
                Image img = pictureBoxVrsta.BackgroundImage;
				
				 String stari_id = vrsta.Tip.Split(' ')[1];
                    //(Tabelarni_prikaz_vrste.vrste).Add(v);
					List<Vrsta> vrste = Tabelarni_prikaz_vrste.vrste;
					int index = -1;
					for (int i = 0; i < vrste.Count; i++)
					{
						if (vrste[i].ID.Equals(vrsta.ID))
						{
							vrste[i].Ime = ime;
							vrste[i].Opis = opis;
							vrste[i].Tip = tip;
							vrste[i].StatusUgrozenosti = status;
							vrste[i].Opasna = opasna;
							vrste[i].CrvenaLista = uicn;
							vrste[i].NaseljeniRegion = region;
							vrste[i].TuristickiStatus = tur_status;
							vrste[i].GodisnjiPrihod = prihod;
							vrste[i].DatumOtkrivanja = datum;
							vrste[i].Img = img;
							index = i;
							break;
						}
					}
                    //dodavanje vrste u listu vrsta odgovarajuce
                    String novi_id = tip.Split(' ')[1];
					List<Etiketa> nove_etikete = new List<Etiketa>();
					List<Etiketa> stare_etikete = new List<Etiketa>();
                    for (int i=0;i< Tabelarni_prikaz_tipa.tipovi.Count;i++)
                    {
						if (Tabelarni_prikaz_tipa.tipovi[i].ID.Equals(stari_id))//prodje kroz star tip vrste i obrise je
                        {
							for (int j = 0; j < Tabelarni_prikaz_tipa.tipovi[i].vrste.Count; j++)
							{
								if (Tabelarni_prikaz_tipa.tipovi[i].vrste[j].ID.Equals(ID))
								{
									Console.WriteLine("Brisi iz stare");
									for (int k = 0; k < Tabelarni_prikaz_tipa.tipovi[i].vrste[j].etikete.Count; k++)
									{
										stare_etikete.Add(Tabelarni_prikaz_tipa.tipovi[i].vrste[j].etikete[k]);//stare
										Tabelarni_prikaz_tipa.tipovi[i].vrste[j].etikete[k].vrsta = vrste[index];
										nove_etikete.Add(Tabelarni_prikaz_tipa.tipovi[i].vrste[j].etikete[k]);//nove
									}
									Tabelarni_prikaz_tipa.tipovi[i].vrste.RemoveAt(j);
									break;
								}
							}
                        }
                    }
					foreach(Etiketa e in stare_etikete)
					{
						if(e.vrsta.ID.Equals(vrsta.ID)){
							Tabelarni_prikaz_etikete.etikete.Remove(e);
							Console.WriteLine("Brisi iz etiketa");
						}
					}
					for(int i =0;i<nove_etikete.Count;i++)
					{
						Tabelarni_prikaz_etikete.etikete.Add(nove_etikete[i]);
						Console.WriteLine("Dodaje u etikete");
					}

					for (int i = 0; i < Tabelarni_prikaz_tipa.tipovi.Count; i++)
					{
						if (Tabelarni_prikaz_tipa.tipovi[i].ID.Equals(novi_id))//prodje kroz novi tip vrste i doda je 
						{
							vrste[index].etikete = nove_etikete;
							Tabelarni_prikaz_tipa.tipovi[i].vrste.Add(vrste[index]);
							Console.WriteLine("Dodaj u novu");
							break;
						}
					}
                this.Close();
            }
            else
            {
                labelError.Text = "Unos nemoguć. \nPostoje greške.";
                labelError.Visible = true;
                timUnos.Start();
            }
        }
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void timUnos_Tick_1(object sender, EventArgs e)
        {
            labelError.Visible = false;
            timUnos.Stop();
        }

        private void textBoxPrihod_Validating(object sender, CancelEventArgs e)
        {
 
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (rx_prihod.Match(textBoxPrihod.Text).Success)
            {
                epUnos.SetError(textBoxPrihod, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                epUnos.SetError(textBoxPrihod, "Prihod moze biti samo u dolarima!");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }

        }

        private void textBoxId_Validating(object sender, CancelEventArgs e)
        {
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (rx_id.Match(textBoxId.Text).Success)
            {
                epUnos.SetError(textBoxId, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                epUnos.SetError(textBoxId, "Id netačno formatirano ili nije uneto.");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }
        }

        private void buttonIzmjeni_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOpis_Validating_1(object sender, CancelEventArgs e)
        {
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (textBoxOpis.Text.Trim()!="")
            {
                epUnos.SetError(textBoxOpis, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                epUnos.SetError(textBoxOpis, "Opis nije unijet.");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }
        }

        private void comboBoxStatus_Validating(object sender, CancelEventArgs e)
        {
            
            if (comboBoxStatus.Text=="Kritično ugrožena" || comboBoxStatus.Text=="Ugrožena" || comboBoxStatus.Text=="Zavisna od očuvanja staništa" ||
            comboBoxStatus.Text=="Blizu rizika" || comboBoxStatus.Text=="Ranjiva" || comboBoxStatus.Text=="Najmanjeg rizika")
            {
                epUnos.SetError(comboBoxStatus, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                epUnos.SetError(comboBoxStatus, "Status je netačno formatirano ili nije unijet.");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }
        }

        private void comboBoxTuristicki_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxTuristicki.Text == "Izolovana" || comboBoxTuristicki.Text == "Djelimično habituirana" || comboBoxTuristicki.Text == "Habituirana")
            {
                epUnos.SetError(comboBoxTuristicki, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                epUnos.SetError(comboBoxTuristicki, "Turistički status je netačno formatirano ili nije unijet.");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTip_Validating(object sender, CancelEventArgs e)
        {
            bool flag = comboBoxTip.Items.Contains(comboBoxTip.Text);
           
            if (flag)
            {
                Console.WriteLine("imaaa");
                epUnos.SetError(comboBoxTip, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                Console.WriteLine("nemaaa");
                //Ovim se podešava da se ispisuje greška.
                epUnos.SetError(comboBoxTip, "Tip je netačno formatirano ili nije unijet.");
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

		private void buttonDodaj_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void buttonDodaj_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void s(object sender, KeyPressEventArgs e)
		{

		}

		private void FormVrsta_Enter(object sender, EventArgs e)
		{
			buttonDodaj.Focus();
		}

		private void FormVrsta_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		private void FormVrsta_Load(object sender, EventArgs e)
		{

		}

	
		private void checkBoxOpasna_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (checkBoxOpasna.Checked)
				{
					checkBoxOpasna.Checked = false;
				}
				else
				{
					checkBoxOpasna.Checked = true;
				}
			}
		}

		private void checkBoxUICN_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (checkBoxUICN.Checked)
				{
					checkBoxUICN.Checked = false;
				}
				else
				{
					checkBoxUICN.Checked = true;
				}
			}
		}

		private void checkBoxRegion_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (checkBoxRegion.Checked)
				{
					checkBoxRegion.Checked = false;
				}
				else
				{
					checkBoxRegion.Checked = true;
				}
			}
		}

        
    }
}
