using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projekat
{
   
    public partial class Tabelarni_prikaz_vrste : Form
    {
        public static List<Vrsta> vrste = new List<Vrsta>();
        public static String koZoveDodaj = "";
        private bool ucitavanje = true;
        private formMain main = null;
        //Vrsta v1 = new Vrsta("desa","macka","ima je samo u domu","macka","Ranjiva","DA","DA","DA","Izolovana",1200,"05-05-1994");
       // Vrsta v2 = new Vrsta("maki", "tigar", "bezveze", "macka", "Ugrožena", "DA", "NE", "DA", "Izolovana", 3200, "04-05-1994");
       // vrste.Add(v1);
        //vrste.Add(v2);
        
        public Tabelarni_prikaz_vrste(formMain main)
        {
            InitializeComponent();
			this.CenterToParent();
            this.main = main;
			comboBoxFilt.SelectedIndex = 3;
        }

        private void Tabelarni_prikaz_vrste_Load(object sender, EventArgs e)
        {
            dataGridViewVrsta.Rows.Clear();
            if (vrste.Count != 0)
            {
                foreach (Vrsta v in vrste)
                {
                    dataGridViewVrsta.Rows.Add(new object[]{v.ID,v.Ime,v.Opis,v.Tip,v.StatusUgrozenosti,v.Opasna,v.CrvenaLista,
                    v.NaseljeniRegion,v.TuristickiStatus,
                    v.GodisnjiPrihod,v.DatumOtkrivanja});
                    dataGridViewVrsta.Rows[dataGridViewVrsta.Rows.Count - 1].Tag = v;
                }
                ucitavanje = false;
                dataGridViewVrsta.CurrentCell = dataGridViewVrsta.Rows[0].Cells[0];
                dataGridViewVrsta_SelectionChanged(dataGridViewVrsta, EventArgs.Empty);
            }
            else//ako nema nijedne tipova,blokiram sve dugmice osim za dodavanje
            {
                buttonDodaj.Enabled = true;
                buttonIzmjena.Enabled = false;
                buttonBrisanje.Enabled = false;
            }
            

        }

        private void dataGridViewVrsta_SelectionChanged(object sender, EventArgs e)
        {
            if (ucitavanje) return;
            if (dataGridViewVrsta.SelectedRows.Count == 0)
            {
                textBoxID.Text = "";
                textBoxIme.Text = "";
                textBoxLista.Text = "";
                textBoxOpis.Text = "";
                textBoxPrihod.Text = "";
                textBoxDatum.Text = "";
                textBoxTip.Text = "";
                textBoxOpasna.Text = "";
                textBoxRegion.Text = "";
                textBoxStatus.Text = "";
                textBoxTuristi.Text = "";
                return;
            }
           
                Vrsta v = (Vrsta)dataGridViewVrsta.SelectedRows[0].Tag;
               
                if (v == null) return;
                textBoxID.Text = v.ID;
                textBoxIme.Text = v.Ime;
                textBoxLista.Text = v.CrvenaLista;
                textBoxTip.Text = v.Tip;
                textBoxOpis.Text = v.Opis;
                textBoxPrihod.Text = (v.GodisnjiPrihod).ToString();
                textBoxDatum.Text = v.DatumOtkrivanja;
                textBoxOpasna.Text = v.Opasna;
                textBoxRegion.Text = v.NaseljeniRegion;
                textBoxStatus.Text = v.StatusUgrozenosti;
                textBoxTuristi.Text = v.TuristickiStatus;
                pictureBoxVrsta.BackgroundImage = v.Img;
          
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            koZoveDodaj = "dodaj";
            FormVrsta vrsta = new FormVrsta(main);
            DialogResult r = vrsta.ShowDialog();
            //da odmah osvjezi tabelu
            dataGridViewVrsta.Rows.Clear();
            foreach (Vrsta v in vrste)
            {
                dataGridViewVrsta.Rows.Add(new object[]{v.ID,v.Ime,v.Opis,v.Tip,v.StatusUgrozenosti,v.Opasna,v.CrvenaLista,
                    v.NaseljeniRegion,v.TuristickiStatus,
                    v.GodisnjiPrihod,v.DatumOtkrivanja});
                dataGridViewVrsta.Rows[dataGridViewVrsta.Rows.Count - 1].Tag = v;
            }
            ucitavanje = false;
            dataGridViewVrsta.CurrentCell = dataGridViewVrsta.Rows[0].Cells[0];
            dataGridViewVrsta_SelectionChanged(dataGridViewVrsta, EventArgs.Empty);
            buttonDodaj.Enabled = true;
            buttonIzmjena.Enabled = true;
            buttonBrisanje.Enabled = true;

            main.refreshTree();

        }

        private void buttonIzmjena_Click(object sender, EventArgs e)
        {
            koZoveDodaj = "izmjeni";
            Vrsta vr = new Vrsta(textBoxID.Text, textBoxIme.Text, textBoxOpis.Text, textBoxTip.Text, textBoxStatus.Text, textBoxOpasna.Text,
                textBoxLista.Text, textBoxRegion.Text, textBoxTuristi.Text, Int32.Parse(textBoxPrihod.Text), textBoxDatum.Text,pictureBoxVrsta.BackgroundImage);
            FormVrsta vrsta = new FormVrsta(vr,main);
            DialogResult r = vrsta.ShowDialog();
            dataGridViewVrsta.Rows.Clear();
            foreach (Vrsta v in vrste)
            {
                dataGridViewVrsta.Rows.Add(new object[]{v.ID,v.Ime,v.Opis,v.Tip,v.StatusUgrozenosti,v.Opasna,v.CrvenaLista,
                    v.NaseljeniRegion,v.TuristickiStatus,
                    v.GodisnjiPrihod,v.DatumOtkrivanja});
                dataGridViewVrsta.Rows[dataGridViewVrsta.Rows.Count - 1].Tag = v;
            }
            ucitavanje = false;
            dataGridViewVrsta.CurrentCell = dataGridViewVrsta.Rows[0].Cells[0];
            dataGridViewVrsta_SelectionChanged(dataGridViewVrsta, EventArgs.Empty);
            buttonDodaj.Enabled = true;
            buttonIzmjena.Enabled = true;
            buttonBrisanje.Enabled = true;

            main.refreshTree();
        }


		private void buttonBrisanje_Click(object sender, EventArgs e)
		{
			DialogResult d = MessageBox.Show("Da li da sigurno želite da obrišete vrstu?", "Brisanje vrste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (d.Equals(DialogResult.Yes))
			{
				String ID = textBoxID.Text;
				//brisanje iz svih vrsta

				Vrsta vrsta = dajSelektovanuVrstu();
				//brisanje vrste iz tipa

				String tip_id = vrsta.Tip.Split(' ')[1];
				//Console.WriteLine(tip_id);
				int ind_vrste = 0;//pokupim indeks vrste da bi je kasnije obrisala iz vrste tipa
				int ind_tipa = 0;
				//u slucaju da je izmjenjen tip neke vrste
				//izbrise vrstu iz liste tog tipa i stavi je u listu novog tipa
				List<Tip> tipovi = Tabelarni_prikaz_tipa.tipovi;

				for (int i = 0; i < tipovi.Count; i++)
				{
					for (int j = 0; j < tipovi[i].vrste.Count; j++)
					{
						if (tipovi[i].vrste[j].ID.Equals(ID))
						{
							ind_vrste = tipovi[i].vrste.IndexOf(tipovi[i].vrste[j]);
							ind_tipa = i;
							break;
						}
					}
				}
				tipovi[ind_tipa].vrste.RemoveAt(ind_vrste);//izbrisi vrstu iz liste 
				Vrsta vr = null;
				foreach (Vrsta v in vrste)
				{
					if (ID.Equals(v.ID))
					{
						vr = v;
						vrste.Remove(v);
						break;
					}
				}
				main.refreshTree();//nakon sto obrise vrstu osvjezi stablo
				main.invalidatePanel(vr);
				//kad izbrise red iz tabele, ponovo je popuni
				dataGridViewVrsta.Rows.Clear();
				foreach (Vrsta v in vrste)
				{
					dataGridViewVrsta.Rows.Add(new object[]{v.ID,v.Ime,v.Opis,v.Tip,v.StatusUgrozenosti,v.Opasna,v.CrvenaLista,
                    v.NaseljeniRegion,v.TuristickiStatus,
                    v.GodisnjiPrihod,v.DatumOtkrivanja});
					dataGridViewVrsta.Rows[dataGridViewVrsta.Rows.Count - 1].Tag = v;
				}
				ucitavanje = false;
				if (vrste.Count != 0)
				{
					dataGridViewVrsta.CurrentCell = dataGridViewVrsta.Rows[0].Cells[0];
					dataGridViewVrsta_SelectionChanged(dataGridViewVrsta, EventArgs.Empty);
				}
				else
				{
					pictureBoxVrsta.BackgroundImage = null;
					buttonDodaj.Enabled = true;
					buttonIzmjena.Enabled = false;
					buttonBrisanje.Enabled = false;
				}
			}
		}
		public void srediTabelu()
		{
			dataGridViewVrsta.Rows.Clear();
			foreach (Vrsta v in vrste)
			{
				dataGridViewVrsta.Rows.Add(new object[]{v.ID,v.Ime,v.Opis,v.Tip,v.StatusUgrozenosti,v.Opasna,v.CrvenaLista,
                    v.NaseljeniRegion,v.TuristickiStatus,
                    v.GodisnjiPrihod,v.DatumOtkrivanja});
				dataGridViewVrsta.Rows[dataGridViewVrsta.Rows.Count - 1].Tag = v;
			}
			ucitavanje = false;
			if (vrste.Count != 0)
			{
				dataGridViewVrsta.CurrentCell = dataGridViewVrsta.Rows[0].Cells[0];
				dataGridViewVrsta_SelectionChanged(dataGridViewVrsta, EventArgs.Empty);
			}
			else
			{
				pictureBoxVrsta.BackgroundImage = null;
				buttonDodaj.Enabled = true;
				buttonIzmjena.Enabled = false;
				buttonBrisanje.Enabled = false;
			}
		}

        private void buttonCuvanje_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodajE_Click(object sender, EventArgs e)
        {
                Vrsta vrsta = dajSelektovanuVrstu();
                if(vrsta!=null)
                    Console.WriteLine("Imam vrstu!");
                FormEtiketa etiketa = new FormEtiketa(vrsta);
                DialogResult r = etiketa.ShowDialog();

            
            
        }

        private void buttonPrikazE_Click(object sender, EventArgs e)
        {
            Vrsta vrsta = dajSelektovanuVrstu();
            Tabelarni_prikaz_etikete tEtikete = new Tabelarni_prikaz_etikete(vrsta);
            DialogResult r = tEtikete.ShowDialog();
        }
        public Vrsta dajSelektovanuVrstu()
        {
            Vrsta vrsta = null;
            if (dataGridViewVrsta.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewVrsta.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewVrsta.Rows[selectedrowindex];

                string id = Convert.ToString(selectedRow.Cells["ID"].Value);//preuzimamo ime vrste i proslijedimo etikete
                Console.WriteLine(id);
                //preuzimanje trenutno selekotvane vrste
                foreach (Vrsta v in vrste)
                {
                    if (id.Equals(v.ID))
                    {
                        vrsta = v;
                        break;
                    }
                }

            }
            return vrsta;
        }

		private void textBoxFilt_TextChanged(object sender, EventArgs e)
		{
			String text = textBoxFilt.Text;
			Console.WriteLine(text);
			List<Vrsta> filtrirani = new List<Vrsta>();
			if(comboBoxFilt.SelectedItem!=null)
			{
				String odabrano = (String)comboBoxFilt.SelectedItem;
				if (odabrano.Equals("sve"))
				{
					for (int i = 0; i < vrste.Count; i++)
					{
						String ime = vrste[i].Ime;
						String id = vrste[i].ID;
						String opis = vrste[i].Opis;
						String tip = vrste[i].Tip;
						String ugrozene = vrste[i].StatusUgrozenosti;
						String datum = vrste[i].DatumOtkrivanja;
						String turisti = vrste[i].TuristickiStatus;
						if (ime.Contains(text))
						{
							filtrirani.Add(vrste[i]);
						}
						else if (id.Contains(text))
						{
							filtrirani.Add(vrste[i]);
						}
						else if (opis.Contains(text))
						{
							filtrirani.Add(vrste[i]);
						}
						else if (tip.Contains(text))
						{
							filtrirani.Add(vrste[i]);
						}
						else if (ugrozene.Contains(text))
						{
							filtrirani.Add(vrste[i]);
						}
						else if (turisti.Contains(text))
						{
							filtrirani.Add(vrste[i]);
						}
						else if (datum.Contains(text))
						{
							filtrirani.Add(vrste[i]);
						}
					}
				}
				else if (odabrano.Equals("ID"))
				{
					for (int i = 0; i < vrste.Count; i++)
					{
						String id = vrste[i].ID;
						if (id.Contains(text))
						{
							filtrirani.Add(vrste[i]);
						}
					}
				}
				else if (odabrano.Equals("ime"))
				{
					for (int i = 0; i < vrste.Count; i++)
					{
						String ime = vrste[i].Ime;
						if (ime.Contains(text))
						{
							filtrirani.Add(vrste[i]);
						}
					}
				}
				else if (odabrano.Equals("tip"))
				{
					for (int i = 0; i < vrste.Count; i++)
					{
						String tip = vrste[i].Tip;
						if (tip.Contains(text))
						{
							filtrirani.Add(vrste[i]);
						}
					}
				}
				dataGridViewVrsta.Rows.Clear();
				foreach (Vrsta v in filtrirani)
				{
					dataGridViewVrsta.Rows.Add(new object[]{v.ID,v.Ime,v.Opis,v.Tip,v.StatusUgrozenosti,v.Opasna,v.CrvenaLista,
                    v.NaseljeniRegion,v.TuristickiStatus,
                    v.GodisnjiPrihod,v.DatumOtkrivanja});
					dataGridViewVrsta.Rows[dataGridViewVrsta.Rows.Count - 1].Tag = v;
				}
				ucitavanje = false;
				if (filtrirani.Count != 0)
				{
					dataGridViewVrsta.CurrentCell = dataGridViewVrsta.Rows[0].Cells[0];
					dataGridViewVrsta_SelectionChanged(dataGridViewVrsta, EventArgs.Empty);
				}
				else
				{
					pictureBoxVrsta.BackgroundImage = null;
					buttonDodaj.Enabled = true;
					buttonIzmjena.Enabled = false;
					buttonBrisanje.Enabled = false;
				}
			}
		}
		
		private void button2_Click(object sender, EventArgs e)
		{//pretrazivanje
			String id = tbId.Text;
			String ime = tbIme.Text;
			String status = (String)cbStatus.SelectedItem;//preuzima koji je selektovan status ugrozenosti
			//Console.WriteLine(status);
			String opasna = (cbOpasna.Checked) ? "DA" : "NE";

			String uicn = (cbCrvena.Checked) ? "DA" : "NE";

			String region = (cbRegion.Checked) ? "DA" : "NE";

			String tur_status = (String)cbTuristi.SelectedItem;
			int prihod = 0;
			if(!tbPrihod.Text.Equals(""))
			{
				prihod = Int32.Parse(tbPrihod.Text);
			}
			
			string datum = dateTimePicker1.Value.ToString("dd-MM-yyyy");
			String tip = tbTip.Text;
			String opis = tbOpis.Text;
			List<Vrsta> pretrazeni = new List<Vrsta>();
			if (rbSve.Checked)
			{
				for (int i = 0; i < vrste.Count; i++)
				{
					if (status != null && tur_status != null)//ako nije unijeto u combo box onda je vrijednost null
					{
						if ((id.Equals(vrste[i].ID) || id.Trim().Equals("")) && (ime.Equals(vrste[i].Ime) || ime.Trim().Equals("")) && tur_status.Equals(vrste[i].TuristickiStatus)
						   && status.Equals(vrste[i].StatusUgrozenosti) && (tip.Equals(vrste[i].Tip) || tip.Trim().Equals(""))
							&& (opasna.Equals(vrste[i].Opasna) || opasna.Trim().Equals("")) && (uicn.Equals(vrste[i].CrvenaLista) || uicn.Trim().Equals(""))
							&& (region.Equals(vrste[i].NaseljeniRegion) || region.Trim().Equals("")) && (datum.Equals(vrste[i].DatumOtkrivanja) || datum.Trim().Equals(""))
							&& (prihod == vrste[i].GodisnjiPrihod || prihod == 0))
						{
							pretrazeni.Add(vrste[i]);
						}
					}
					else if (status != null && tur_status == null)
					{
						if ((id.Equals(vrste[i].ID) || id.Trim().Equals("")) && (ime.Equals(vrste[i].Ime) || ime.Trim().Equals(""))
							&& (tip.Equals(vrste[i].Tip) || tip.Trim().Equals("")) && status.Equals(vrste[i].StatusUgrozenosti)
							&& (opasna.Equals(vrste[i].Opasna) || opasna.Trim().Equals("")) && (uicn.Equals(vrste[i].CrvenaLista) || uicn.Trim().Equals(""))
							&& (region.Equals(vrste[i].NaseljeniRegion) || region.Trim().Equals("")) && (datum.Equals(vrste[i].DatumOtkrivanja) || datum.Trim().Equals(""))
							&& (prihod == vrste[i].GodisnjiPrihod || prihod == 0))
						{
							pretrazeni.Add(vrste[i]);
						}

					}
					else if (status == null && tur_status != null)
					{
						if ((id.Equals(vrste[i].ID) || id.Trim().Equals("")) && (ime.Equals(vrste[i].Ime) || ime.Trim().Equals(""))
							&& (tip.Equals(vrste[i].Tip) || tip.Trim().Equals("")) && tur_status.Equals(vrste[i].TuristickiStatus)
							&& (opasna.Equals(vrste[i].Opasna) || opasna.Trim().Equals("")) && (uicn.Equals(vrste[i].CrvenaLista) || uicn.Trim().Equals(""))
							&& (region.Equals(vrste[i].NaseljeniRegion) || region.Trim().Equals("")) && (datum.Equals(vrste[i].DatumOtkrivanja) || datum.Trim().Equals(""))
							&& (prihod == vrste[i].GodisnjiPrihod || prihod == 0))
						{
							pretrazeni.Add(vrste[i]);
						}
					}else if(status == null && tur_status == null)
					{
						if ((id.Equals(vrste[i].ID) || id.Trim().Equals("")) && (ime.Equals(vrste[i].Ime) || ime.Trim().Equals(""))
							&& (tip.Equals(vrste[i].Tip) || tip.Trim().Equals("")) 
							&& (opasna.Equals(vrste[i].Opasna) || opasna.Trim().Equals("")) && (uicn.Equals(vrste[i].CrvenaLista) || uicn.Trim().Equals(""))
							&& (region.Equals(vrste[i].NaseljeniRegion) || region.Trim().Equals("")) && (datum.Equals(vrste[i].DatumOtkrivanja) || datum.Trim().Equals(""))
							&& (prihod == vrste[i].GodisnjiPrihod || prihod == 0))
						{
							pretrazeni.Add(vrste[i]);
						}
						if (id.Trim().Equals("") && ime.Trim().Equals("")  && tip.Trim().Equals("")
							&& opasna.Trim().Equals("") && uicn.Trim().Equals("")
							&& region.Trim().Equals("") && datum.Trim().Equals("")
							&& prihod == 0)
						{
							pretrazeni.Remove(vrste[i]);
						}
					}
				}
				ispisiTabelu(pretrazeni);
			}
			else if (rbMakarJedan.Checked)
			{
				for (int i = 0; i < vrste.Count; i++)
				{
					if (status != null && tur_status != null)//ako nije unijeto u combo box onda je vrijednost null
					{
						if (id.Equals(vrste[i].ID) || ime.Equals(vrste[i].Ime) || tip.Equals(vrste[i].Tip) || opasna.Equals(vrste[i].Opasna) || uicn.Equals(vrste[i].CrvenaLista) ||
								region.Equals(vrste[i].NaseljeniRegion) || datum.Equals(vrste[i].DatumOtkrivanja) || prihod == vrste[i].GodisnjiPrihod
								|| tur_status.Equals(vrste[i].TuristickiStatus) || status.Equals(vrste[i].StatusUgrozenosti))
						{
							pretrazeni.Add(vrste[i]);
						}
					}
					else if (status != null && tur_status == null)
					{
						if (id.Equals(vrste[i].ID) || ime.Equals(vrste[i].Ime) || tip.Equals(vrste[i].Tip) || opasna.Equals(vrste[i].Opasna) || uicn.Equals(vrste[i].CrvenaLista) ||
								region.Equals(vrste[i].NaseljeniRegion) || datum.Equals(vrste[i].DatumOtkrivanja) || prihod == vrste[i].GodisnjiPrihod
								|| status.Equals(vrste[i].StatusUgrozenosti))
						{
							pretrazeni.Add(vrste[i]);
						}
					}
					else if (status == null && tur_status != null)
					{
						if (id.Equals(vrste[i].ID) || ime.Equals(vrste[i].Ime) || tip.Equals(vrste[i].Tip) || opasna.Equals(vrste[i].Opasna) || uicn.Equals(vrste[i].CrvenaLista) ||
								region.Equals(vrste[i].NaseljeniRegion) || datum.Equals(vrste[i].DatumOtkrivanja) || prihod == vrste[i].GodisnjiPrihod
								|| tur_status.Equals(vrste[i].TuristickiStatus))
						{
							pretrazeni.Add(vrste[i]);
						}
					}
					else if (status == null && tur_status == null)
					{
						if (id.Equals(vrste[i].ID) || ime.Equals(vrste[i].Ime) || tip.Equals(vrste[i].Tip) || opasna.Equals(vrste[i].Opasna) || uicn.Equals(vrste[i].CrvenaLista) ||
								region.Equals(vrste[i].NaseljeniRegion) || datum.Equals(vrste[i].DatumOtkrivanja) || prihod == vrste[i].GodisnjiPrihod)
						{
							pretrazeni.Add(vrste[i]);
						}
						if (id.Trim().Equals("") && ime.Trim().Equals("") && tip.Trim().Equals("")
							&& opasna.Trim().Equals("") && uicn.Trim().Equals("")
							&& region.Trim().Equals("") && datum.Trim().Equals("")
							&& prihod == 0)
						{
							pretrazeni.Remove(vrste[i]);
						}
					}
				}
				ispisiTabelu(pretrazeni);
			}
			else
			{
				MessageBox.Show("Za pretraživanje je potrebno da označiti da li pretražujete po svim unesenim parametrima ili po makar jednom!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
		}
		private void ispisiTabelu(List<Vrsta> pretrazeni)
		{
			dataGridViewVrsta.Rows.Clear();
			foreach (Vrsta v in pretrazeni)
			{
				dataGridViewVrsta.Rows.Add(new object[]{v.ID,v.Ime,v.Opis,v.Tip,v.StatusUgrozenosti,v.Opasna,v.CrvenaLista,
                    v.NaseljeniRegion,v.TuristickiStatus,
                    v.GodisnjiPrihod,v.DatumOtkrivanja});
				dataGridViewVrsta.Rows[dataGridViewVrsta.Rows.Count - 1].Tag = v;
			}
			ucitavanje = false;
			if (pretrazeni.Count != 0)
			{
				dataGridViewVrsta.CurrentCell = dataGridViewVrsta.Rows[0].Cells[0];
				dataGridViewVrsta_SelectionChanged(dataGridViewVrsta, EventArgs.Empty);
			}
			else
			{
				pictureBoxVrsta.BackgroundImage = null;
				buttonDodaj.Enabled = true;
				buttonIzmjena.Enabled = false;
				buttonBrisanje.Enabled = false;
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			dataGridViewVrsta.Rows.Clear();
			if (vrste.Count != 0)
			{
				foreach (Vrsta v in vrste)
				{
					dataGridViewVrsta.Rows.Add(new object[]{v.ID,v.Ime,v.Opis,v.Tip,v.StatusUgrozenosti,v.Opasna,v.CrvenaLista,
                    v.NaseljeniRegion,v.TuristickiStatus,
                    v.GodisnjiPrihod,v.DatumOtkrivanja});
					dataGridViewVrsta.Rows[dataGridViewVrsta.Rows.Count - 1].Tag = v;
				}
				ucitavanje = false;
				dataGridViewVrsta.CurrentCell = dataGridViewVrsta.Rows[0].Cells[0];
				dataGridViewVrsta_SelectionChanged(dataGridViewVrsta, EventArgs.Empty);
			}
			else//ako nema nijedne tipova,blokiram sve dugmice osim za dodavanje
			{
				buttonDodaj.Enabled = true;
				buttonIzmjena.Enabled = false;
				buttonBrisanje.Enabled = false;
			}
		}

		private void dataGridViewVrsta_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
    }
}
