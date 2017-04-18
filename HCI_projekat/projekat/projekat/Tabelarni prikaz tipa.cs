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
    public partial class Tabelarni_prikaz_tipa : Form
    {
        public static List<Tip> tipovi = new List<Tip>();
        public static String koZoveDodaj = "";
        private bool ucitavanje = true;
        private formMain main = null;
        public Tabelarni_prikaz_tipa(formMain main)
        {
            InitializeComponent();
			this.CenterToParent();
            this.main = main;
			comboBoxFilt.SelectedIndex = 3;
			onemoguciUpis();
          //  Tip t = new Tip("desetka", "macka", "ima lijepe nogice");
           // tipovi.Add(t);
        }
		public void onemoguciUpis()
		{
			textBoxId.Enabled = false;
			textBoxIme.Enabled = false;
			textBoxOpis.Enabled = false;
		}

        private void buttonDodavanje_Click(object sender, EventArgs e)
        {
            koZoveDodaj = "dodaj";
            FormTip tip = new FormTip(main);
            DialogResult r = tip.ShowDialog();

            dataGridViewTip.Rows.Clear();
            foreach (Tip t in tipovi)
            {
                dataGridViewTip.Rows.Add(new object[]{t.ID,t.Ime,t.Opis});
                dataGridViewTip.Rows[dataGridViewTip.Rows.Count - 1].Tag = t;
            }
            ucitavanje = false;
            dataGridViewTip.CurrentCell = dataGridViewTip.Rows[0].Cells[0];
            dataGridViewTip_SelectionChanged(dataGridViewTip, EventArgs.Empty);
            buttonDodavanje.Enabled = true;
            buttonIzmjena.Enabled = true;
            buttonBrisanje.Enabled = true;
			main.refreshTree();
        }

        private void buttonIzmjena_Click(object sender, EventArgs e)
        {
            koZoveDodaj = "izmjeni";
            Tip tip = new Tip(textBoxId.Text,textBoxIme.Text,textBoxOpis.Text,pictureBoxTip.BackgroundImage);
            FormTip ftip = new FormTip(tip,main);
            DialogResult r = ftip.ShowDialog();

            dataGridViewTip.Rows.Clear();
            foreach (Tip t in tipovi)
            {
                dataGridViewTip.Rows.Add(new object[] { t.ID, t.Ime, t.Opis });
                dataGridViewTip.Rows[dataGridViewTip.Rows.Count - 1].Tag = t;
            }
            ucitavanje = false;
            dataGridViewTip.CurrentCell = dataGridViewTip.Rows[0].Cells[0];
            dataGridViewTip_SelectionChanged(dataGridViewTip, EventArgs.Empty);
            buttonDodavanje.Enabled = true;
            buttonIzmjena.Enabled = true;
            buttonBrisanje.Enabled = true;
        }

		private void buttonBrisanje_Click(object sender, EventArgs e)
		{
			DialogResult d = MessageBox.Show("Da li da sigurno želite da obrišete tip?", "Brisanje tipa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (d.Equals(DialogResult.Yes))
			{
				String ID = textBoxId.Text;
				Tip tip = dajSelektovaniTip();

				DijalogZaBrisanje dzb = new DijalogZaBrisanje(main, tip);
				dzb.ShowDialog();

				//kad izbrise red iz tabele, ponovo je popuni
				main.refreshTree();
				dataGridViewTip.Rows.Clear();
				foreach (Tip t in tipovi)
				{
					dataGridViewTip.Rows.Add(new object[] { t.ID, t.Ime, t.Opis });
					dataGridViewTip.Rows[dataGridViewTip.Rows.Count - 1].Tag = t;
				}
				ucitavanje = false;
				if (tipovi.Count != 0)
				{
					dataGridViewTip.CurrentCell = dataGridViewTip.Rows[0].Cells[0];
					dataGridViewTip_SelectionChanged(dataGridViewTip, EventArgs.Empty);
				}
				else
				{
					pictureBoxTip.BackgroundImage = null;
					buttonDodavanje.Enabled = true;
					buttonIzmjena.Enabled = false;
					buttonBrisanje.Enabled = false;
				}
			}
		}

        private void Tabelarni_prikaz_tipa_Load(object sender, EventArgs e)
        {
            dataGridViewTip.Rows.Clear();
            if (tipovi.Count != 0)
            {
                foreach (Tip t in tipovi)
                {
                    dataGridViewTip.Rows.Add(new object[] { t.ID, t.Ime, t.Opis });
                    dataGridViewTip.Rows[dataGridViewTip.Rows.Count - 1].Tag = t;
                }
                ucitavanje = false;
                dataGridViewTip.CurrentCell = dataGridViewTip.Rows[0].Cells[0];
                dataGridViewTip_SelectionChanged(dataGridViewTip, EventArgs.Empty);
            }
            else//ako nema nijedne tipova,blokiram sve dugmice osim za dodavanje
            {
                buttonDodavanje.Enabled = true;
                buttonIzmjena.Enabled = false;
                buttonBrisanje.Enabled = false;
            }
        }

        private void dataGridViewTip_SelectionChanged(object sender, EventArgs e)
        {
            if (ucitavanje) return;
            if (dataGridViewTip.SelectedRows.Count == 0)
            {
                textBoxId.Text = "";
                textBoxIme.Text = "";
                textBoxOpis.Text = "";
              
                return;
            }

            Tip t = (Tip)dataGridViewTip.SelectedRows[0].Tag;

            if (t == null) return;
            textBoxId.Text = t.ID;
            textBoxIme.Text = t.Ime;
            textBoxOpis.Text = t.Opis;
            pictureBoxTip.BackgroundImage=t.Img; 
           
        }

        private void pictureBoxTip_Click(object sender, EventArgs e)
        {

        }
        public List<Tip> dajListuTipova()
        {
            return tipovi;
        }
        public Tip dajSelektovaniTip()
        {
            Tip tip = null;
            if (dataGridViewTip.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewTip.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewTip.Rows[selectedrowindex];

                string id = Convert.ToString(selectedRow.Cells["ID"].Value);//preuzimamo ime vrste i proslijedimo etikete
                Console.WriteLine(id);
                //preuzimanje trenutno selekotvane vrste
                foreach (Tip t in tipovi)
                {
                    if (id.Equals(t.ID))
                    {
                        tip = t;
                        break;
                    }
                }

            }
            return tip;
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void textBoxFilt_TextChanged(object sender, EventArgs e)
		{
			String text = textBoxFilt.Text;
			Console.WriteLine(text);
			List<Tip> filtrirani = new List<Tip>();
			if (comboBoxFilt.SelectedItem != null)
			{
				String odabrano = (String)comboBoxFilt.SelectedItem;
				if (odabrano.Equals("sve"))
				{
					for (int i = 0; i < tipovi.Count; i++)
					{
						String ime = tipovi[i].Ime;
						String id = tipovi[i].ID;
						String opis = tipovi[i].Opis;
						if (ime.Contains(text))
						{
							filtrirani.Add(tipovi[i]);
						}
						else if (id.Contains(text))
						{
							filtrirani.Add(tipovi[i]);
						}
						else if (opis.Contains(text))
						{
							filtrirani.Add(tipovi[i]);
						}
					}
				}
				else if (odabrano.Equals("ID"))
				{
					for (int i = 0; i < tipovi.Count; i++)
					{
						String id = tipovi[i].ID;
						if (id.Contains(text))
						{
							filtrirani.Add(tipovi[i]);
						}
					}
				}
				else if (odabrano.Equals("ime"))
				{
					for (int i = 0; i < tipovi.Count; i++)
					{
						String ime = tipovi[i].Ime;
						if (ime.Contains(text))
						{
							filtrirani.Add(tipovi[i]);
						}
					}
				}
				else if (odabrano.Equals("opis"))
				{
					for (int i = 0; i < tipovi.Count; i++)
					{
						String opis = tipovi[i].Opis;
						if (opis.Contains(text))
						{
							filtrirani.Add(tipovi[i]);
						}
					}
				}

				dataGridViewTip.Rows.Clear();
				if (filtrirani.Count != 0)
				{

					foreach (Tip t in filtrirani)
					{
						dataGridViewTip.Rows.Add(new object[] { t.ID, t.Ime, t.Opis });
						dataGridViewTip.Rows[dataGridViewTip.Rows.Count - 1].Tag = t;
					}
					ucitavanje = false;
					dataGridViewTip.CurrentCell = dataGridViewTip.Rows[0].Cells[0];
					dataGridViewTip_SelectionChanged(dataGridViewTip, EventArgs.Empty);
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

		private void button1_Click_1(object sender, EventArgs e)
		{
			List<Tip> pretrazeni = new List<Tip>();
			String id = tbId.Text;
			String ime = tbIme.Text;
			String opis = tbOpis.Text;
			if (radioButton1.Checked)
			{

				for (int i = 0; i < tipovi.Count; i++)
				{
					if ((id.Equals(tipovi[i].ID)|| id.Trim().Equals("")) && (ime.Equals(tipovi[i].Ime)||ime.Trim().Equals(""))
						&& (opis.Equals(tipovi[i].Opis) || opis.Trim().Equals("")))
					{
						pretrazeni.Add(tipovi[i]);
					}
					if (id.Trim().Equals("") && ime.Trim().Equals("") && opis.Trim().Equals(""))
					{
						pretrazeni.Remove(tipovi[i]);
					}
				}
				ispisiTabelu(pretrazeni);
			}
			else if (radioButton2.Checked)
			{
				for (int i = 0; i < tipovi.Count; i++)
				{
					if (id.Equals(tipovi[i].ID) || ime.Equals(tipovi[i].Ime) || opis.Equals(tipovi[i].Opis))
					{
						pretrazeni.Add(tipovi[i]);
					}

				}
				ispisiTabelu(pretrazeni);
			}
			else
			{
				MessageBox.Show("Za pretraživanje je potrebno da označiti da li pretražujete po svim unesenim parametrima ili po makar jednom!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
		}
		private void ispisiTabelu(List<Tip> pretrazeni)
		{
			dataGridViewTip.Rows.Clear();
			if (pretrazeni.Count != 0)
			{

				foreach (Tip t in pretrazeni)
				{
					dataGridViewTip.Rows.Add(new object[] { t.ID, t.Ime, t.Opis });
					dataGridViewTip.Rows[dataGridViewTip.Rows.Count - 1].Tag = t;
				}
				ucitavanje = false;
				dataGridViewTip.CurrentCell = dataGridViewTip.Rows[0].Cells[0];
				dataGridViewTip_SelectionChanged(dataGridViewTip, EventArgs.Empty);
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
		{//prikazi sve tipove
			dataGridViewTip.Rows.Clear();
			if (tipovi.Count != 0)
			{
				foreach (Tip t in tipovi)
				{
					dataGridViewTip.Rows.Add(new object[] { t.ID, t.Ime, t.Opis });
					dataGridViewTip.Rows[dataGridViewTip.Rows.Count - 1].Tag = t;
				}
				ucitavanje = false;
				dataGridViewTip.CurrentCell = dataGridViewTip.Rows[0].Cells[0];
				dataGridViewTip_SelectionChanged(dataGridViewTip, EventArgs.Empty);
			}
			else//ako nema nijedne tipova,blokiram sve dugmice osim za dodavanje
			{
				buttonDodavanje.Enabled = true;
				buttonIzmjena.Enabled = false;
				buttonBrisanje.Enabled = false;
			}
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void Tabelarni_prikaz_tipa_KeyDown(object sender, KeyEventArgs e)
		{
		}
    }
}
