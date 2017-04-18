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
	public partial class BiranjeTipa : Form
	{
		private Tip tip = null;
		private formMain main = null;
		public BiranjeTipa(Tip tip,formMain main)
		{
			InitializeComponent();
			this.CenterToParent();
			this.tip = tip;
			this.main = main;

			foreach (Tip t in Tabelarni_prikaz_tipa.tipovi)
			{
				if (!t.ID.Equals(tip.ID))
				{
					comboBoxTipovi.Items.Add(t.Ime + " " + t.ID);
				}
			}

		}

		private void comboBoxTipovi_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void comboBoxTipovi_SelectedValueChanged(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String ime_id = (String)comboBoxTipovi.SelectedItem;
			String tip_id = ime_id.Split(' ')[1];
			List<Tip> tipovi = Tabelarni_prikaz_tipa.tipovi;

			List<Vrsta> vrste = Tabelarni_prikaz_vrste.vrste;

			Tip t = null;//pronalazi tip kome pripada id
			for (int i = 0; i < tipovi.Count; i++)
			{
				if (tipovi[i].ID.Equals(tip_id))
				{
					t = tipovi[i];
					break;
				}
			}

			for (int i = 0; i < tip.vrste.Count; i++)
			{
				tip.vrste[i].Tip = t.Ime + " " + t.ID;
				t.vrste.Add(tip.vrste[i]);

			}
			for (int i = 0; i < Tabelarni_prikaz_vrste.vrste.Count; i++)
			{
				if (Tabelarni_prikaz_vrste.vrste[i].Tip.Equals(ime_id))
				{
					Tabelarni_prikaz_vrste.vrste[i].Tip = t.Ime + " " + t.ID;
					break;
				}
			}
			int ind = 0;
			for (int l = 0; l < tipovi.Count; l++)
			{
				if (tip.ID.Equals(tipovi[l].ID))
				{
					ind = l;
					break;
				}
			}
			tipovi.RemoveAt(ind);//obrise i tip iz liste tipova
			main.refreshTree();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
