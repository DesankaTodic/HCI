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
    public partial class DijalogZaBrisanje : Form
    {
        Tip tip = null;
		private formMain main = null;
        public DijalogZaBrisanje(formMain main,Tip  tip)
        {
			this.main = main;
            this.tip = tip;      
			InitializeComponent();
			this.CenterToParent();
			if (tip.vrste.Count == 0)
				radioButton2.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (radioButton1.Checked)//obrisi sve i tip i njegove vrste
           {
			   List<Tip> tipovi = Tabelarni_prikaz_tipa.tipovi;
           
                List<Vrsta> vrste = Tabelarni_prikaz_vrste.vrste;
				List<Vrsta> neobrisane_vrste = new List<Vrsta>();

                for (int i = 0; i < vrste.Count; i++)
                {                  
                    String tip_id = vrste[i].Tip.Split(' ')[1];
					if (!tip.ID.Equals(tip_id))
					{		
						neobrisane_vrste.Add(vrste[i]);//ako vrste ne pripadaju datoj listi,smjesti ih u listu
					}
					else
					{
						main.invalidatePanel(vrste[i]);//ako su to vrste za brisanje,obrisi ih sa slike
					}
                }
				Tabelarni_prikaz_vrste.vrste = neobrisane_vrste;
			   
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
				if (Tabelarni_prikaz_tipa.tipovi.Count == 0)
				{
					main.initilizeItems();
				}

		   }
		   else if (radioButton2.Checked)
		   {
			   BiranjeTipa bt = new BiranjeTipa(tip,main);
			   bt.ShowDialog();
			   if (Tabelarni_prikaz_tipa.tipovi.Count == 0)
			   {
				   main.initilizeItems();
			   }
		   }

		   this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
			this.Close();
        }
		
    }
}
