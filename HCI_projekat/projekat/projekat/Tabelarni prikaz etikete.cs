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
    public partial class Tabelarni_prikaz_etikete : Form
    {
        public static List<Etiketa> etikete = new List<Etiketa>();
        public static String koZoveDodaj = "";
        private bool ucitavanje = true;
        private Vrsta vrsta = null;
		private formMain main = null;
		private bool flag_za_sve = false;

        public Tabelarni_prikaz_etikete(Vrsta vrsta)
        {
            InitializeComponent();
			this.CenterToParent();
            this.vrsta = vrsta;
			this.Text = "Tabelarni prikaz etiketa vrste";
			comboBoxFilt.SelectedIndex = 2;
            // Etiketa et = new Etiketa("desetka", Color.Tomato, "bas je ugrozena");
             //etikete.Add(et);
        }
        public Tabelarni_prikaz_etikete(formMain main,Vrsta vrsta)
        {
            InitializeComponent();
			this.CenterToParent();
			this.vrsta = vrsta;
			this.main = main;
			comboBoxFilt.SelectedIndex = 2;
			this.Text = "Tabelarni prikaz etiketa vrste";
            // Etiketa et = new Etiketa("desetka", Color.Tomato, "bas je ugrozena");
            //etikete.Add(et);
        }
		public Tabelarni_prikaz_etikete(formMain main,bool flag_za_sve)//konstruktor za prikaz svih etiketa
		{
			InitializeComponent();
			this.CenterToParent();
			this.main = main;
			this.flag_za_sve = flag_za_sve;
			this.Text = "Tabelarni prikaz svih etiketa";
			// Etiketa et = new Etiketa("desetka", Color.Tomato, "bas je ugrozena");
			//etikete.Add(et);
		}
        private void buttonDodavanje_Click(object sender, EventArgs e)
        {
            koZoveDodaj = "dodaj";
            FormEtiketa et = new FormEtiketa(vrsta);
            DialogResult r = et.ShowDialog();

            dataGridViewEtiketa.Rows.Clear();
            foreach (Etiketa etik in vrsta.etikete)
            {
                dataGridViewEtiketa.Rows.Add(new object[] { etik.ID, "", etik.Opis });
                dataGridViewEtiketa[1, dataGridViewEtiketa.Rows.Count - 1].Style.BackColor = etik.Boja;
                dataGridViewEtiketa.Rows[dataGridViewEtiketa.Rows.Count - 1].Tag = etik;
            }
            ucitavanje = false;
            dataGridViewEtiketa.CurrentCell = dataGridViewEtiketa.Rows[0].Cells[0];
            dataGridViewEtiketa_SelectionChanged(dataGridViewEtiketa, EventArgs.Empty);
            buttonDodavanje.Enabled = true;
            buttonIzmjena.Enabled = true;
            buttonBrisanje.Enabled = true;
        }

        private void Tabelarni_prikaz_etikete_Load(object sender, EventArgs e)
        {
            dataGridViewEtiketa.Rows.Clear();
			if (flag_za_sve)//treba prikazzati sve etikete
			{
				if (etikete.Count != 0)
				{
					foreach (Etiketa etik in etikete)
					{
						dataGridViewEtiketa.Rows.Add(new object[] { etik.ID, "", etik.Opis });
						dataGridViewEtiketa[1, dataGridViewEtiketa.Rows.Count - 1].Style.BackColor = etik.Boja;
						dataGridViewEtiketa.Rows[dataGridViewEtiketa.Rows.Count - 1].Tag = etik;
					}
					ucitavanje = false;

					dataGridViewEtiketa.CurrentCell = dataGridViewEtiketa.Rows[0].Cells[0];
					dataGridViewEtiketa_SelectionChanged(dataGridViewEtiketa, EventArgs.Empty);
					buttonDodavanje.Enabled = false;//dodavanje nije dozvoljeno ako su prikazane sve etikete
					buttonIzmjena.Enabled = true;
					buttonBrisanje.Enabled = true;
				}
				else//ako nema nijedne etikete,blokiram sve dugmice osim za dodavanje
				{
					buttonDodavanje.Enabled = false;
					buttonIzmjena.Enabled = false;
					buttonBrisanje.Enabled = false;
				}
			}
			else//treba prikazati samo etikete date vrste
			{
				//if (vrsta == null)//ako je load iz tulbara, nema vrsta, pa uzmem selektovani cvor, inace uzimam selektovani cvor iz tabele
				//{
				//    TreeNode node = main.dajSelektovaniCvor();
				//    vrsta = (Vrsta)node.Tag;
				//}
				if (vrsta.etikete.Count != 0)
				{
					foreach (Etiketa etik in vrsta.etikete)
					{
						dataGridViewEtiketa.Rows.Add(new object[] { etik.ID, "", etik.Opis });
						dataGridViewEtiketa[1, dataGridViewEtiketa.Rows.Count - 1].Style.BackColor = etik.Boja;
						dataGridViewEtiketa.Rows[dataGridViewEtiketa.Rows.Count - 1].Tag = etik;
					}
					ucitavanje = false;

					dataGridViewEtiketa.CurrentCell = dataGridViewEtiketa.Rows[0].Cells[0];
					dataGridViewEtiketa_SelectionChanged(dataGridViewEtiketa, EventArgs.Empty);
					buttonDodavanje.Enabled = true;
					buttonIzmjena.Enabled = true;
					buttonBrisanje.Enabled = true;
				}
				else//ako nema nijedne etikete,blokiram sve dugmice osim za dodavanje
				{
					buttonDodavanje.Enabled = true;
					buttonIzmjena.Enabled = false;
					buttonBrisanje.Enabled = false;
				}
			}
        }

        private void dataGridViewEtiketa_SelectionChanged(object sender, EventArgs e)
        {
            if (ucitavanje) return;
            if (dataGridViewEtiketa.SelectedRows.Count == 0)
            {
                textBoxId.Text = "";
                textBoxBoja.BackColor = Color.White;
                textBoxOpis.Text = "";

                return;
            }

            Etiketa et = (Etiketa)dataGridViewEtiketa.SelectedRows[0].Tag;

            if (et == null) return;
            textBoxId.Text = et.ID;
            textBoxBoja.BackColor = et.Boja;
            textBoxOpis.Text = et.Opis;
           
        }

        private void buttonIzmjena_Click(object sender, EventArgs e)
        {
            koZoveDodaj = "izmjeni";
            Etiketa et = new Etiketa(textBoxId.Text, textBoxBoja.BackColor, textBoxOpis.Text);
            FormEtiketa fe = new FormEtiketa(et,vrsta);
            DialogResult r = fe.ShowDialog();

            dataGridViewEtiketa.Rows.Clear();
			if (flag_za_sve)
			{
				foreach (Etiketa etik in etikete)
				{
					dataGridViewEtiketa.Rows.Add(new object[] { etik.ID, "", etik.Opis });
					dataGridViewEtiketa[1, dataGridViewEtiketa.Rows.Count - 1].Style.BackColor = etik.Boja;
					dataGridViewEtiketa.Rows[dataGridViewEtiketa.Rows.Count - 1].Tag = etik;
				}
				ucitavanje = false;

				dataGridViewEtiketa.CurrentCell = dataGridViewEtiketa.Rows[0].Cells[0];
				dataGridViewEtiketa_SelectionChanged(dataGridViewEtiketa, EventArgs.Empty);
				buttonDodavanje.Enabled = false;
				buttonIzmjena.Enabled = true;
				buttonBrisanje.Enabled = true;
			}
			else
			{
				foreach (Etiketa etik in vrsta.etikete)
				{
					dataGridViewEtiketa.Rows.Add(new object[] { etik.ID, "", etik.Opis });
					dataGridViewEtiketa[1, dataGridViewEtiketa.Rows.Count - 1].Style.BackColor = etik.Boja;
					dataGridViewEtiketa.Rows[dataGridViewEtiketa.Rows.Count - 1].Tag = etik;
				}
				ucitavanje = false;

				dataGridViewEtiketa.CurrentCell = dataGridViewEtiketa.Rows[0].Cells[0];
				dataGridViewEtiketa_SelectionChanged(dataGridViewEtiketa, EventArgs.Empty);
				buttonDodavanje.Enabled = true;
				buttonIzmjena.Enabled = true;
				buttonBrisanje.Enabled = true;
			}
        }

        private void buttonBrisanje_Click(object sender, EventArgs e)
        {
			DialogResult d = MessageBox.Show("Da li da sigurno želite da obrišete etiketu?", "Brisanje etikete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (d.Equals(DialogResult.Yes))
			{
				String ID = textBoxId.Text;
				if (flag_za_sve)//ako su prikazane sve etikete
				{
					Vrsta vr = null;
					foreach (Etiketa etik in etikete)
					{
						if (ID.Equals(etik.ID))
						{
							vr = etik.vrsta;
							vr.etikete.Remove(etik);
							etikete.Remove(etik);

							break;
						}
					}
					//kad izbrise red iz tabele, ponovo je popuni
					dataGridViewEtiketa.Rows.Clear();
					foreach (Etiketa et in etikete)
					{
						dataGridViewEtiketa.Rows.Add(new object[] { et.ID, "", et.Opis });
						dataGridViewEtiketa[1, dataGridViewEtiketa.Rows.Count - 1].Style.BackColor = et.Boja;
						dataGridViewEtiketa.Rows[dataGridViewEtiketa.Rows.Count - 1].Tag = et;
					}
					ucitavanje = false;
					if (etikete.Count != 0)
					{
						dataGridViewEtiketa.CurrentCell = dataGridViewEtiketa.Rows[0].Cells[0];
						dataGridViewEtiketa_SelectionChanged(dataGridViewEtiketa, EventArgs.Empty);
					}
					else
					{
						buttonDodavanje.Enabled = false;
						buttonIzmjena.Enabled = false;
						buttonBrisanje.Enabled = false;
					}
				}
				else//kada je brisanje iz etiketa nekog tipa
				{
					foreach (Etiketa etik in vrsta.etikete)
					{
						if (ID.Equals(etik.ID))
						{
							vrsta.etikete.Remove(etik);
							etikete.Remove(etik);//brisanje iz svih etiketa
							break;
						}
					}
					//kad izbrise red iz tabele, ponovo je popuni
					dataGridViewEtiketa.Rows.Clear();
					foreach (Etiketa et in vrsta.etikete)
					{
						dataGridViewEtiketa.Rows.Add(new object[] { et.ID, "", et.Opis });
						dataGridViewEtiketa[1, dataGridViewEtiketa.Rows.Count - 1].Style.BackColor = et.Boja;
						dataGridViewEtiketa.Rows[dataGridViewEtiketa.Rows.Count - 1].Tag = et;
					}
					ucitavanje = false;
					if (vrsta.etikete.Count != 0)
					{
						dataGridViewEtiketa.CurrentCell = dataGridViewEtiketa.Rows[0].Cells[0];
						dataGridViewEtiketa_SelectionChanged(dataGridViewEtiketa, EventArgs.Empty);
					}
					else
					{
						buttonDodavanje.Enabled = true;
						buttonIzmjena.Enabled = false;
						buttonBrisanje.Enabled = false;
					}
				}
			}
			
        }

		private void textBoxOpis_TextChanged(object sender, EventArgs e)
		{

		}

		private void labelOpis_Click(object sender, EventArgs e)
		{

		}

		private void textBoxFilt_TextChanged(object sender, EventArgs e)
		{

			String text = textBoxFilt.Text;
			Console.WriteLine(text);
			List<Etiketa> filtrirani = new List<Etiketa>();
			if (comboBoxFilt.SelectedItem != null)
			{
				String odabrano = (String)comboBoxFilt.SelectedItem;
				if (odabrano.Equals("sve"))
				{
					for (int i = 0; i < vrsta.etikete.Count; i++)
					{
						String id = vrsta.etikete[i].ID;
						String opis = vrsta.etikete[i].Opis;
						if (id.Contains(text))
						{
							filtrirani.Add(vrsta.etikete[i]);
						}
						else if (opis.Contains(text))
						{
							filtrirani.Add(vrsta.etikete[i]);
						}
					}
				}
				else if (odabrano.Equals("ID"))
				{
					for (int i = 0; i < vrsta.etikete.Count; i++)
					{
						String id = vrsta.etikete[i].ID;
						if (id.Contains(text))
						{
							filtrirani.Add(vrsta.etikete[i]);
						}
					}
				}
				else if (odabrano.Equals("opis"))
				{
					for (int i = 0; i < vrsta.etikete.Count; i++)
					{
						String opis = vrsta.etikete[i].Opis;
						if (opis.Contains(text))
						{
							filtrirani.Add(vrsta.etikete[i]);
						}
					}
				}

				dataGridViewEtiketa.Rows.Clear();
				if (filtrirani.Count != 0)
				{

					foreach (Etiketa et in filtrirani)
					{
						dataGridViewEtiketa.Rows.Add(new object[] { et.ID, "", et.Opis });
						dataGridViewEtiketa[1, dataGridViewEtiketa.Rows.Count - 1].Style.BackColor = et.Boja;
						dataGridViewEtiketa.Rows[dataGridViewEtiketa.Rows.Count - 1].Tag = et;
					}
					ucitavanje = false;
					dataGridViewEtiketa.CurrentCell = dataGridViewEtiketa.Rows[0].Cells[0];
					dataGridViewEtiketa_SelectionChanged(dataGridViewEtiketa, EventArgs.Empty);
					buttonDodavanje.Enabled = true;
					buttonIzmjena.Enabled = true;
					buttonBrisanje.Enabled = true;
				}
				else
				{
					buttonDodavanje.Enabled = true;
					buttonIzmjena.Enabled = false;
					buttonBrisanje.Enabled = false;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{//pretrazivanje
			String id = tbId.Text;
			String opis = tbOpis.Text;
			List<Etiketa> pretrazeni = new List<Etiketa>();
			if (rbSve.Checked)
			{
				for (int i = 0; i < vrsta.etikete.Count; i++)
				{
					if (id.Equals(vrsta.etikete[i].ID) && opis.Equals(vrsta.etikete[i].Opis))
					{
						pretrazeni.Add(vrsta.etikete[i]);
					}
					else if (id.Trim().Equals("") && opis.Equals(vrsta.etikete[i].Opis))
					{
						pretrazeni.Add(vrsta.etikete[i]);
					}
					else if (id.Equals(vrsta.etikete[i].ID) && opis.Trim().Equals(""))
					{
						pretrazeni.Add(vrsta.etikete[i]);
					}

				}
				ispisiTabelu(pretrazeni);
			}
			else if (rbMakarJedan.Checked)
			{
				for (int i = 0; i < vrsta.etikete.Count; i++)
				{
					if (id.Equals(vrsta.etikete[i].ID) || opis.Equals(vrsta.etikete[i].Opis))
					{
						pretrazeni.Add(vrsta.etikete[i]);
					}
					if (id.Trim().Equals("") && opis.Trim().Equals(""))
					{
						pretrazeni.Remove(vrsta.etikete[i]);
					}
					

				}
				ispisiTabelu(pretrazeni);
			}
			else
			{
				MessageBox.Show("Za pretraživanje je potrebno da označiti da li pretražujete po svim unesenim parametrima ili po makar jednom!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
		}

		private void ispisiTabelu(List<Etiketa> pretrazeni)
		{
			dataGridViewEtiketa.Rows.Clear();
			if (pretrazeni.Count != 0)
			{

				foreach (Etiketa et in pretrazeni)
				{
					dataGridViewEtiketa.Rows.Add(new object[] { et.ID, "", et.Opis });
					dataGridViewEtiketa[1, dataGridViewEtiketa.Rows.Count - 1].Style.BackColor = et.Boja;
					dataGridViewEtiketa.Rows[dataGridViewEtiketa.Rows.Count - 1].Tag = et;
				}
				ucitavanje = false;
				dataGridViewEtiketa.CurrentCell = dataGridViewEtiketa.Rows[0].Cells[0];
				dataGridViewEtiketa_SelectionChanged(dataGridViewEtiketa, EventArgs.Empty);
				buttonDodavanje.Enabled = true;
				buttonIzmjena.Enabled = true;
				buttonBrisanje.Enabled = true;
			}
			else
			{
				buttonDodavanje.Enabled = true;
				buttonIzmjena.Enabled = false;
				buttonBrisanje.Enabled = false;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (flag_za_sve)
			{
				dataGridViewEtiketa.Rows.Clear();
				foreach (Etiketa et in etikete)
				{
					dataGridViewEtiketa.Rows.Add(new object[] { et.ID, "", et.Opis });
					dataGridViewEtiketa[1, dataGridViewEtiketa.Rows.Count - 1].Style.BackColor = et.Boja;
					dataGridViewEtiketa.Rows[dataGridViewEtiketa.Rows.Count - 1].Tag = et;
				}
				ucitavanje = false;
				if (etikete.Count != 0)
				{
					dataGridViewEtiketa.CurrentCell = dataGridViewEtiketa.Rows[0].Cells[0];
					dataGridViewEtiketa_SelectionChanged(dataGridViewEtiketa, EventArgs.Empty);
				}
				else
				{
					buttonDodavanje.Enabled = true;
					buttonIzmjena.Enabled = false;
					buttonBrisanje.Enabled = false;
				}
			}
			else
			{
				dataGridViewEtiketa.Rows.Clear();
				foreach (Etiketa et in vrsta.etikete)
				{
					dataGridViewEtiketa.Rows.Add(new object[] { et.ID, "", et.Opis });
					dataGridViewEtiketa[1, dataGridViewEtiketa.Rows.Count - 1].Style.BackColor = et.Boja;
					dataGridViewEtiketa.Rows[dataGridViewEtiketa.Rows.Count - 1].Tag = et;
				}
				ucitavanje = false;
				if (vrsta.etikete.Count != 0)
				{
					dataGridViewEtiketa.CurrentCell = dataGridViewEtiketa.Rows[0].Cells[0];
					dataGridViewEtiketa_SelectionChanged(dataGridViewEtiketa, EventArgs.Empty);
				}
				else
				{
					buttonDodavanje.Enabled = true;
					buttonIzmjena.Enabled = false;
					buttonBrisanje.Enabled = false;
				}
			}
		}

		private void Tabelarni_prikaz_etikete_KeyDown(object sender, KeyEventArgs e)
		{

		}
    }
}
