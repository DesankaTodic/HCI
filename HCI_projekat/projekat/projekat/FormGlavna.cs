using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace projekat
{
    public partial class formMain : Form
    {
        Repozitorijum r = new Repozitorijum();
        public ImageList myImageList = new ImageList();
		public Dictionary<string, Vrsta> vrsteNaMapi = new Dictionary<string, Vrsta>();
	
		public static List<TreeNode> NodesOnMap
		{
			get { return formMain.nodesOnMap; }
			set { formMain.nodesOnMap = value; }
		}

        private Point selPoint = new Point(-1, -1);

		private static Dictionary<TreeNode, Point> pozicije = new Dictionary<TreeNode, Point>();

		public static Dictionary<TreeNode, List<Point>> sve_pozicije = new Dictionary<TreeNode, List<Point>>();
	
		public static List<TreeNode> nodesOnMap = new List<TreeNode>();

		private bool demoMode = false;
        
        public formMain()
        {
            InitializeComponent();
			Image image = new Bitmap(@"..\..\..\..\world_map_resize.gif");
			image = new Bitmap(image, new Size(panelMapa.Width, panelMapa.Height));
			panelMapa.BackgroundImage = image;
			if (treeView1.SelectedNode == null)
			{
				initilizeItems();
			}
			this.CenterToScreen();
			
        }
		public void initilizeItems(){
			
				izmjeniv.Enabled = false;
				izmjenit.Enabled = false;
				izmjenimeniv.Enabled = false;
				izmjenimenit.Enabled = false;
				dodajv.Enabled = false;
				dodajmeniv.Enabled = false;
				brisiv.Enabled = false;
				brisit.Enabled = false;
				obrisimeniv.Enabled = false;
				obrisimenit.Enabled = false;
				dodaje.Enabled = false;
				dodajmenie.Enabled = false;
				prikazie.Enabled = false;
				prikazimenie.Enabled = false;	
			
		}
        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DialogResult d = MessageBox.Show("Da li želite da izađete?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d.Equals(DialogResult.Yes))
            {
                r.MemorisiDatotekuVrsta();
                r.MemorisiDatotekuTipova();
                r.MemorisiDatotekuEtiketa();
				r.MemorisiDatotekuCvorova();
				r.MemorisiDatotekuLokacija();
                Application.ExitThread();//da ne bi morali 2x pritisnuti yes 
            }
        }

        private void dodajVrstuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVrsta vrsta = new FormVrsta(this);
            DialogResult r = vrsta.ShowDialog();
        }

        private void dodajEtiketuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtiketa etiketa = new FormEtiketa();
            DialogResult r = etiketa.ShowDialog();
        }

        private void dodajTipVrsteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTip tip = new FormTip(this);
            DialogResult r = tip.ShowDialog();
			refreshTree();
        }

        private void tabelarniPrikazVrsteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabelarni_prikaz_vrste tVrsta = new Tabelarni_prikaz_vrste(this);
            DialogResult r = tVrsta.ShowDialog();

        }

        private void tabelarniPrikazTipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabelarni_prikaz_tipa tTip = new Tabelarni_prikaz_tipa(this);
            DialogResult r = tTip.ShowDialog();
        }

        private void tabelarniPrikazEtiketeToolStripMenuItem_Click(object sender, EventArgs e)
        {
			TreeNode node = treeView1.SelectedNode;
			Vrsta vrsta = (Vrsta)node.Tag;
            Tabelarni_prikaz_etikete tEtikete = new Tabelarni_prikaz_etikete(this,vrsta);
            DialogResult r = tEtikete.ShowDialog();
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Da li želite da izađete?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d.Equals(DialogResult.Yes))
            {
                r.MemorisiDatotekuVrsta();
                r.MemorisiDatotekuTipova();
                r.MemorisiDatotekuEtiketa();
				r.MemorisiDatotekuCvorova();
				r.MemorisiDatotekuLokacija();
                Application.ExitThread();//da ne bi morali 2x pritisnuti yes 
            }
            else if (d.Equals(DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
			TreeNode node = treeView1.SelectedNode;
			if (node.Tag is Tip)
			{
				izmjeniv.Enabled = false;
				izmjenit.Enabled = true;
				izmjenimeniv.Enabled = false;
				izmjenimenit.Enabled = true;
				dodajv.Enabled = true;
				dodajmeniv.Enabled = true;
				brisiv.Enabled = false;
				brisit.Enabled = true;
				obrisimeniv.Enabled = false;
				obrisimenit.Enabled = true;
				dodaje.Enabled = false;
				dodajmenie.Enabled = false;
				prikazie.Enabled = false;
				prikazimenie.Enabled = false;		
			}
			else if (node.Tag is Vrsta)
			{
				izmjeniv.Enabled = true;
				izmjenit.Enabled = false;
				izmjenimeniv.Enabled = true;
				izmjenimenit.Enabled = false;
				dodajv.Enabled = true;
				dodajmeniv.Enabled = true;
				brisiv.Enabled = true;
				brisit.Enabled = false;
				obrisimeniv.Enabled = true;
				obrisimenit.Enabled = false;
				dodaje.Enabled = true;
				dodajmenie.Enabled = true;
				prikazie.Enabled = true;
				prikazimenie.Enabled = true;
			}
			
        }
		private bool isctrajPonovo = true;
        private void formMain_Load(object sender, EventArgs e)
        {
            initilizeTree();
			isctrajPonovo = false;
			poruka.Visible = false;
			
        }
        public void initilizeTree()
        {
            List<Tip> tipovi = Tabelarni_prikaz_tipa.tipovi;

            
            treeView1.ImageList = myImageList;
            treeView1.ImageList.ImageSize = new Size(30, 30);
            int index = 0;
            for (int i = 0; i < tipovi.Count; i++)
            {
                myImageList.Images.Add(tipovi[i].Img);
                TreeNode node = new TreeNode(tipovi[i].Ime);
				node.ForeColor = Color.Gray;
                node.ImageIndex = index;
                node.SelectedImageIndex = index;
                this.treeView1.Nodes.Add(node);
                treeView1.Nodes[i].Tag = tipovi[i];
                index++;
               for (int j = 0; j < tipovi[i].vrste.Count; j++)
                {
                   Tip tip = tipovi[i];
                   Vrsta v = tip.vrste[j];
                    Image image = v.Img;
                    if (image == null)
                        Console.WriteLine("Nemaa slike");
                    else
                    {
                        myImageList.Images.Add(image);
                    }
                   TreeNode node1 = new TreeNode(tipovi[i].vrste[j].Ime);
                   node1.ImageIndex = index;
                   node1.SelectedImageIndex = index;
                   node1.Tag = tipovi[i].vrste[j];
				   tipovi[i].vrste[j].treeNode = node1;
                   this.treeView1.Nodes[i].Nodes.Add(node1);
                   if (image != null)
                        index++;

				   TreeNode key = null;
				   foreach (KeyValuePair<TreeNode, List<Point>> entry in sve_pozicije)
				   {
					   if (entry.Key.Text == node1.Text)
					   {
						   key = entry.Key;
						   break;
					   }
				   }

				   if (key == null)
				   {
					   continue;
				   }
				   for (int p = 0; p < panelMapa.Controls.Count; p++)//kad se desi izmjena ikonice vrste da je promjeni i na mapi
				   {
					   PictureBox pb = (PictureBox)panelMapa.Controls[p];
					   Tuple<Point, TreeNode> tuple = (Tuple<Point, TreeNode>)pb.Tag;
					   if (tuple.Item2.Text.Equals(node1.Text))
					   {
						   pb.Image = tipovi[i].vrste[j].Img;
					   }

				   }

				   if (sve_pozicije.ContainsKey(key) && isctrajPonovo)
				  // if (sve_pozicije.ContainsKey(key))
				   {
					   
					   //panelMapa.Controls.Clear();
					   List<Point> tacke = sve_pozicije[key];
					   for (int k = 0; k < tacke.Count; k++)
					   {
						   PictureBox pb = new PictureBox();
						   pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
						   pb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
						   pb.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);

						   pb.ContextMenuStrip = new ContextMenuStrip();
						   ToolStripDropDownItem item = new ToolStripMenuItem();
						   item.Text = "Obriši";
						   item.Click += obriToolStripMenuItem_Click;
						   pb.ContextMenuStrip.Items.Add(item);
						   pb.ContextMenuStrip.Tag = new Tuple<Point, PictureBox>(tacke[k], pb);
						   pb.Image = tipovi[i].vrste[j].Img;
						   pb.Size = new System.Drawing.Size(30, 30);
						   pb.SizeMode = PictureBoxSizeMode.StretchImage;
						   pb.Name = tipovi[i].vrste[j].Ime;
						   pb.Tag = new Tuple<Point, TreeNode>(tacke[k], key);
						   pb.Location = new Point(tacke[k].X, tacke[k].Y);

						   panelMapa.Controls.Add(pb);
						   listPB.Add(pb);
					   }
				   }
                }

            }
            if (treeView1.Nodes.Count > 0)
            {
                treeView1.SelectedNode = treeView1.Nodes[0];
                treeView1.HideSelection = false;
            }
        }
		public void refreshTree()
		{
			treeView1.Nodes.Clear();
			myImageList.Images.Clear();
			initilizeTree();
		}

		private TreeNode selektovani = null;
		private Rectangle selekcioniProzor;
		private Point tackaEkrana;
		private bool prevuciSaStabla;
		private bool prevuciSaMape;
		private Control draggedPictureBox;
		private PictureBox selektovanaSlika;
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {		
			selektovani = treeView1.GetNodeAt(e.Location);
			if (selektovani != null)
			{
				if (selektovani.Tag is Vrsta)
				{
					if (e.Button == MouseButtons.Right)
					{
						contextMenuVrsta.Show(treeView1.PointToScreen(e.Location));
					}
					treeView1.SelectedNode = selektovani;
					string oznaka = selektovani.Text;
					if (selektovani.GetNodeCount(true) == 0)
					{
						Size dragVelicina = SystemInformation.DragSize;     //Sistemsko podešavanje "mrtve zone" miša za drag & drop
						selekcioniProzor = new Rectangle(new Point(e.X - (dragVelicina.Width / 2), e.Y - (dragVelicina.Height / 2)), dragVelicina); //Prozor u kome _ne_ počinjemo drag operaciju.
					}
					else
						selekcioniProzor = Rectangle.Empty;    //Postavljanjem praznog rectangle-a označavamo da je nemoguć drag
				}
				else if (selektovani.Tag is Tip)
				{
				    if (e.Button == MouseButtons.Right)
				    {
				        contextMenuTip.Show(treeView1.PointToScreen(e.Location));
				    }
				}
			}
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {

			if (e.Button == MouseButtons.Left)
			{
				if (selekcioniProzor != Rectangle.Empty && (!selekcioniProzor.Contains(e.X, e.Y)))   //Da li smo izašli iz "mrtve zone"?
				{
					tackaEkrana = SystemInformation.WorkingArea.Location;
					try
					{
						prevuciSaStabla = true;
						DragDropEffects dropEfekat = this.treeView1.DoDragDrop(selektovani, DragDropEffects.Copy);
					}
					catch (NullReferenceException)
					{
					}
				}
			}
			
        }

        private void panelMapa_DragEnter(object sender, DragEventArgs e)
        {
			Type testTip = new TreeNode().GetType();
			if ((e.Data.GetDataPresent(testTip)))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None; 
        }
		
		private List<PictureBox> listPB = new List<PictureBox>();


		private bool jeSlika(Point p1, Point p2)  //poziva je ova metoda ispod
		{                                        //p1 je koordinata slike, dok je p2 kursor misa
			if (p2.X > p1.X && p2.X < p1.X + 30 && p2.Y > p1.Y && p2.Y < p1.Y + 30)
			{
				return true;
			}
			return false;
		}

        private void panelMapa_DragDrop(object sender, DragEventArgs e)
        {
			Point panelLokacija = panelMapa.PointToScreen(Point.Empty);
			Rectangle draggedElement = new Rectangle(new Point(e.X - panelLokacija.X, e.Y - panelLokacija.Y), new Size(5, 5));

			bool presjek = false;
			foreach (Control pb in panelMapa.Controls)
			{
				if (draggedElement.IntersectsWith(pb.Bounds))
				{
					presjek = true;
					MessageBox.Show("Vrste se ne smiju preklapati!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			if (prevuciSaStabla)
			{
				Type testTip = new TreeNode().GetType();
				Panel dropPicturePanel = (Panel)sender;
				TreeNode prevuceniCvor;

				prevuciSaStabla = false;
				selekcioniProzor = Rectangle.Empty;
				if (e.Data.GetDataPresent(testTip) && presjek == false) //Da li je poslati tip u stvari treeNode?
				{
					prevuceniCvor = (TreeNode)e.Data.GetData(testTip);
					prevuceniCvor.ImageIndex = prevuceniCvor.Index;
					prevuceniCvor.SelectedImageIndex = prevuceniCvor.Index;
					//PictureBox pb = new PictureBox();
					PictureBox pb = new PictureBox();

					pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
					pb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
					pb.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);

					pb.ContextMenuStrip = new ContextMenuStrip();
					ToolStripDropDownItem item = new ToolStripMenuItem();
					item.Text = "Obriši";
					item.Click += obriToolStripMenuItem_Click;
					pb.ContextMenuStrip.Items.Add(item);

					//pb.Image = imageList1.Images[prevuceniCvor.Index];
					Vrsta vrsta = (Vrsta)prevuceniCvor.Tag;
					pb.Image = vrsta.Img;
					refreshTree();
					pb.Size = new System.Drawing.Size(30, 30);
					pb.SizeMode = PictureBoxSizeMode.StretchImage;
					Point lokacijaPanela = panelMapa.PointToScreen(Point.Empty);   //  izracuna lokaciju u odnosu na panel
					pb.Location = new System.Drawing.Point(e.X - lokacijaPanela.X, e.Y - lokacijaPanela.Y);
					
					///panelMapa.Controls.Add(pb);

					string oznaka = prevuceniCvor.Text;
					pb.Name = oznaka;   //  cuvam za kasnije prevlacenje po mapi
					panelMapa.Controls.Add(pb);
					listPB.Add(pb);//dodajem u listu pb 

					Point lokacija = new Point(pb.Location.X - panelMapa.AutoScrollPosition.X,
									  pb.Location.Y - panelMapa.AutoScrollPosition.Y);     //  u odnosu na panel i skrol
					//SpomenikMapa snmp = new SpomenikMapa(oznaka, true, lokacija);
					//bool snimio = PodaciSpomenici.getInstance().getSpomeniciMapa().saveSpomenikNaMapi(snmp);
					//vrsteNaMapi.Add(vrsta.ID, vrsta);
					treeView1.SelectedNode = prevuceniCvor;
					//pozicije.Add(prevuceniCvor, lokacija);
					pb.Tag = new Tuple<Point, TreeNode>(lokacija, prevuceniCvor);//potrebno mi je da pamti ko mu je treenode i poziciju za kasniji drag i drop 
																				//posto ne cuva pozicije nakon drag and drop po panelu
					pb.ContextMenuStrip.Tag = new Tuple<Point, PictureBox>(lokacija, pb);

					TreeNode key = null;
					foreach (KeyValuePair<TreeNode, List<Point>> entry in sve_pozicije)
					{
						if (entry.Key.Text == prevuceniCvor.Text)
						{
							key = entry.Key;
							break;
						}
					}

					if (key != null)
					{
						List<Point> tacke = sve_pozicije[key];
						tacke.Add(lokacija);
					}
					else
					{
						List<Point> tacke = new List<Point>();
						tacke.Add(lokacija);
						sve_pozicije.Add(prevuceniCvor, tacke);
					}

				}
				
				
			}
			else    // ako nije sa stabla, onda je po panelu
			{
				Type testTip = new PictureBox().GetType();
				Panel dropPicturePanel = (Panel)sender;
				PictureBox droppedPictureBox;

				prevuciSaMape = false;
				selekcioniProzor = Rectangle.Empty;

				if (e.Data.GetDataPresent(testTip) && presjek == false) //Da li je poslati tip u stvari treeNode?
				{
					droppedPictureBox = (PictureBox)e.Data.GetData(testTip);

					Point lokacijaPanela = panelMapa.PointToScreen(Point.Empty);   //  izracuna lokaciju u odnosu na panel
					droppedPictureBox.Location = new System.Drawing.Point(e.X - lokacijaPanela.X, e.Y - lokacijaPanela.Y);

					string oznaka = droppedPictureBox.Name;
					Point lokacija = new Point(droppedPictureBox.Location.X - panelMapa.AutoScrollPosition.X,
					                  droppedPictureBox.Location.Y - panelMapa.AutoScrollPosition.Y);     //  u odnosu na panel i skrol
					Tuple<Point, TreeNode> tuple = (Tuple<Point, TreeNode>)droppedPictureBox.Tag;
					TreeNode prevuceniCvor = tuple.Item2;
					Point stara_lokacija = tuple.Item1;
					////PodaciSpomenici.getInstance().getSpomeniciMapa().izmeniSpomenikNaMapi(oznaka, true, lokacija);
					foreach (KeyValuePair<TreeNode, List<Point>> entry in sve_pozicije)
					{
						if (entry.Key.Text == prevuceniCvor.Text)
						{
							List<Point> tacke = entry.Value;
							for (int i = 0; i < tacke.Count; i++)
							{
								if (stara_lokacija.X == tacke[i].X && stara_lokacija.Y == tacke[i].Y)
								{
									tacke[i] = lokacija;
									droppedPictureBox.Tag = new Tuple<Point, TreeNode>(lokacija, prevuceniCvor);
									droppedPictureBox.ContextMenuStrip.Tag = new Tuple<Point, PictureBox>(lokacija, droppedPictureBox);
									break;
								}
							}
						}
					}
				}
			}
        }

        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;

        }
		private void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			draggedPictureBox = (PictureBox)sender;
			selektovanaSlika = (PictureBox)sender;

			if (draggedPictureBox.Parent == panelMapa)
			{
				Size dragVelicina = SystemInformation.DragSize;
				selekcioniProzor = new Rectangle(new Point(e.X - (dragVelicina.Width / 2), e.Y - (dragVelicina.Height / 2)), dragVelicina);
			}
		}

		private void pictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (selekcioniProzor != Rectangle.Empty && (!selekcioniProzor.Contains(e.X, e.Y)))
				{
					prevuciSaMape = true;
					tackaEkrana = SystemInformation.WorkingArea.Location;
					DragDropEffects dropEffect = this.panelMapa.DoDragDrop(draggedPictureBox, DragDropEffects.Move);
				}
			}
		}
		private void pictureBox_MouseHover(object sender, EventArgs e)
		{
			PictureBox pb = (PictureBox)sender;
			ToolTip tt = new ToolTip();

			pb.Cursor = Cursors.Hand;
			tt.SetToolTip(pb, pb.Name);

		}
        private void panelMapa_MouseClick(object sender, MouseEventArgs e)
        {
			if (demoMode)
			{
				NormalanMode();
				return;
			}
        }

		//private bool dozvoljeno = false;
        private void panelMapa_MouseMove(object sender, MouseEventArgs e)
        {
			//int mwidth = 30;
			//int mheight = 30;
			//if (prevuciSaStabla)
			//{
			//    for (int i = 0; i < panelMapa.Controls.Count; i++)
			//    {

			//        Point p = new Point(panelMapa.Controls[i].Bounds.X, panelMapa.Controls[i].Bounds.Y);
			//        if (panelMapa.Controls[i].Bounds.Contains(new Point(e.X, e.Y)))
			//        {

			//            this.Cursor = Cursors.No;
			//            //dozvoljeno = false;
			//            return;
			//        }
			//    }
			//    this.Cursor = Cursors.SizeAll;
			//    //dozvoljeno = true;
			//}
			//else
			//{
			//    this.Cursor = Cursors.Arrow;
			//}
        }

        private void panelMapa_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void panelMapa_Paint(object sender, PaintEventArgs e)
        {
			Graphics g = e.Graphics;
			for (int i = 0; i < nodesOnMap.Count; i++)
			{
			    Point p = new Point();
			    Vrsta vrsta = (Vrsta)nodesOnMap[i].Tag;
			    foreach (KeyValuePair<TreeNode, Point> entry in pozicije)
			    {
			        if (entry.Key.Text.Equals(nodesOnMap[i].Text))
			        {
			            p = entry.Value;
			        }
			    }
			    Image img = new Bitmap(vrsta.Img, new Size(30, 30));
			    g.DrawImage(img, new Point(p.X, p.Y));
			}
        }

		public void invalidatePanel(Vrsta vrsta)
		{
			TreeNode node = vrsta.treeNode;

			TreeNode key = null;
			foreach (KeyValuePair<TreeNode, List<Point>> entry in sve_pozicije)
			{
				if (entry.Key.Text == node.Text)
				{
					key = entry.Key;
					break;
				}
			}

			if (key == null)
			{
				return;
			}

			Dictionary<TreeNode, List<Point>> sve_pozicije1 = new Dictionary<TreeNode, List<Point>>(sve_pozicije);

			foreach (KeyValuePair<TreeNode, List<Point>> entry in sve_pozicije1)
			{
				if (entry.Key.Text.Equals(vrsta.Ime))
				{
					pozicije.Remove(key);
					sve_pozicije.Remove(key);
					foreach(PictureBox pb in listPB)
					{
						if (pb.Name.Equals(vrsta.Ime))
						{
							panelMapa.Controls.Remove(pb);
							Console.WriteLine("Obrsisamo sam " + vrsta.Ime);
						}
					}
				}
			}

			panelMapa.Invalidate();
		}

		private void toolStripLabel1_Click(object sender, EventArgs e)
		{//dodavanje tipa
			FormTip tip = new FormTip(this);
			DialogResult r = tip.ShowDialog();
			refreshTree();
		}

		private void toolStripLabel2_Click(object sender, EventArgs e)
		{//izmjena tipa
			TreeNode node = treeView1.SelectedNode;
			if(node.Tag is Tip)
			{
				Tip tip = (Tip) node.Tag;
				Tabelarni_prikaz_tipa.koZoveDodaj = "izmjeni";
				FormTip ftip = new FormTip(tip,this);
				DialogResult r = ftip.ShowDialog();
				refreshTree();
			}
			
		}

		private void toolStripLabel3_Click(object sender, EventArgs e)
		{//brisanje tipa
			TreeNode node = treeView1.SelectedNode;
			if (node.Tag is Tip)
			{
				Tip tip = (Tip)node.Tag;
				DijalogZaBrisanje dzb = new DijalogZaBrisanje(this,tip);
				dzb.ShowDialog();
				refreshTree();
				
			}
		}

		private void toolStripLabel4_Click(object sender, EventArgs e)
		{//prikaz tipova
			Tabelarni_prikaz_tipa tTip = new Tabelarni_prikaz_tipa(this);
			DialogResult r = tTip.ShowDialog();
		}

		private void toolStripLabel5_Click(object sender, EventArgs e)
		{//dodavanje vrste
			Tabelarni_prikaz_vrste.koZoveDodaj = "dodaj";
			FormVrsta vrsta = new FormVrsta(this);
			DialogResult r = vrsta.ShowDialog();
		}

		private void toolStripLabel6_Click(object sender, EventArgs e)
		{//izmjena vrste
			TreeNode node = treeView1.SelectedNode;
			if (node.Tag is Vrsta)
			{
				Vrsta vrsta = (Vrsta)node.Tag;
				Tabelarni_prikaz_vrste.koZoveDodaj = "izmjeni";
				FormVrsta fvrste= new FormVrsta(vrsta,this);
				DialogResult r = fvrste.ShowDialog();
				
				refreshTree();
			}
		}

		private void toolStripLabel7_Click(object sender, EventArgs e)
		{//brisanje vrste
			brisanjeVrste();
		}
		public void brisanjeVrste()
		{
			DialogResult d = MessageBox.Show("Da li da sigurno želite da obrišete vrstu?", "Brisanje vrste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (d.Equals(DialogResult.Yes))
			{
				TreeNode node = treeView1.SelectedNode;
				if (node.Tag is Vrsta)
				{
					Vrsta vrsta = (Vrsta)node.Tag;
					int ind_vrste = 0;//pokupim indeks vrste da bi je kasnije obrisala iz vrste tipa
					int ind_tipa = 0;
					List<Tip> tipovi = Tabelarni_prikaz_tipa.tipovi;

					for (int i = 0; i < tipovi.Count; i++)
					{
						for (int j = 0; j < tipovi[i].vrste.Count; j++)
						{
							if (tipovi[i].vrste[j].ID.Equals(vrsta.ID))
							{
								ind_vrste = tipovi[i].vrste.IndexOf(tipovi[i].vrste[j]);
								ind_tipa = i;
								break;
							}
						}
					}
					tipovi[ind_tipa].vrste.RemoveAt(ind_vrste);//izbrisi vrstu iz liste 
					Vrsta vr = null;
					foreach (Vrsta v in Tabelarni_prikaz_vrste.vrste)
					{
						if (vrsta.ID.Equals(v.ID))
						{
							vr = v;
							Tabelarni_prikaz_vrste.vrste.Remove(v);
							break;
						}
					}
					refreshTree();
					invalidatePanel(vr);
				}
			}
		}
		private void toolStripLabel8_Click(object sender, EventArgs e)
		{//prikazi vrste
			Tabelarni_prikaz_vrste tVrsta = new Tabelarni_prikaz_vrste(this);
			DialogResult r = tVrsta.ShowDialog();
		}

		private void toolStripLabel9_Click(object sender, EventArgs e)
		{//dodavanje etikete
			TreeNode node = treeView1.SelectedNode;
			Vrsta vrsta = (Vrsta)node.Tag;
			FormEtiketa etiketa = new FormEtiketa(vrsta);
			DialogResult r = etiketa.ShowDialog();
		}
		public TreeNode dajSelektovaniCvor()
		{
			return treeView1.SelectedNode;
		}

		private void toolStripLabel12_Click(object sender, EventArgs e)
		{//prikazi etikete jedne vrste
			TreeNode node = treeView1.SelectedNode;
			Vrsta vrsta = (Vrsta)node.Tag;
			Tabelarni_prikaz_etikete tEtikete = new Tabelarni_prikaz_etikete(this, vrsta);
			DialogResult r = tEtikete.ShowDialog();
		}

		private void toolStripLabel14_Click(object sender, EventArgs e)
		{//prikazi etikete svih vrsta
			Tabelarni_prikaz_etikete tEtikete = new Tabelarni_prikaz_etikete(this,true);
			DialogResult r = tEtikete.ShowDialog();
		}

		private void prikazimenise_Click(object sender, EventArgs e)
		{
			Tabelarni_prikaz_etikete tEtikete = new Tabelarni_prikaz_etikete(this, true);
			DialogResult r = tEtikete.ShowDialog();
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{//dodavanje tipa
			FormTip tip = new FormTip(this);
			DialogResult r = tip.ShowDialog();
			refreshTree();
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{//izmjena tipa
			TreeNode node = treeView1.SelectedNode;
			if (node.Tag is Tip)
			{
				Tip tip = (Tip)node.Tag;
				Tabelarni_prikaz_tipa.koZoveDodaj = "izmjeni";
				FormTip ftip = new FormTip(tip,this);
				DialogResult r = ftip.ShowDialog();
				refreshTree();
			}

		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{//brisanje tipa
			TreeNode node = treeView1.SelectedNode;
			if (node.Tag is Tip)
			{
				Tip tip = (Tip)node.Tag;
				DijalogZaBrisanje dzb = new DijalogZaBrisanje(this, tip);
				dzb.ShowDialog();
				refreshTree();

			}

		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{//dodavanje vrste
			Tabelarni_prikaz_vrste.koZoveDodaj = "dodaj";
			FormVrsta vrsta = new FormVrsta(this);
			DialogResult r = vrsta.ShowDialog();

		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{//izmjena vrste
			TreeNode node = treeView1.SelectedNode;
			if (node.Tag is Vrsta)
			{
				Vrsta vrsta = (Vrsta)node.Tag;
				Tabelarni_prikaz_vrste.koZoveDodaj = "izmjeni";
				FormVrsta fvrste = new FormVrsta(vrsta, this);
				DialogResult r = fvrste.ShowDialog();
				//isctrajPonovo = true;
				refreshTree();
				//isctrajPonovo = false;
			}

		}

		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{
			brisanjeVrste();
		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{//dodavanje etikete
			TreeNode node = treeView1.SelectedNode;
			Vrsta vrsta = (Vrsta)node.Tag;
			FormEtiketa etiketa = new FormEtiketa(vrsta);
			DialogResult r = etiketa.ShowDialog();

		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, "..\\..\\..\\..\\HelpPrimer.chm");
		}

		private void izmjenimenit_Click(object sender, EventArgs e)
		{//izmjena tipa
			TreeNode node = treeView1.SelectedNode;
			if (node.Tag is Tip)
			{
				Tip tip = (Tip)node.Tag;
				Tabelarni_prikaz_tipa.koZoveDodaj = "izmjeni";
				FormTip ftip = new FormTip(tip,this);
				DialogResult r = ftip.ShowDialog();
				refreshTree();
			}

		}

		private void izmjenimeniv_Click(object sender, EventArgs e)
		{//izmjena vrste
			TreeNode node = treeView1.SelectedNode;
			if (node.Tag is Vrsta)
			{
				Vrsta vrsta = (Vrsta)node.Tag;
				Tabelarni_prikaz_vrste.koZoveDodaj = "izmjeni";
				FormVrsta fvrste = new FormVrsta(vrsta, this);
				DialogResult r = fvrste.ShowDialog();
				refreshTree();
			}

		}

		private void obrisimenit_Click(object sender, EventArgs e)
		{
			//brisanje tipa
			TreeNode node = treeView1.SelectedNode;
			if (node.Tag is Tip)
			{
				Tip tip = (Tip)node.Tag;
				DijalogZaBrisanje dzb = new DijalogZaBrisanje(this, tip);
				dzb.ShowDialog();
				refreshTree();

			}
		}

		private void obrisimeniv_Click(object sender, EventArgs e)
		{//brisanje vrste
			brisanjeVrste();
		}
		public void PonoviDemo()
		{
			toolStripMenuItem10.PerformClick();
		}

		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{//demo mode
			poruka.Visible = true;
			demoMode = true;
			panelMapa.BackColor = Color.Gainsboro;
			treeView1.BackColor = Color.Gainsboro;
			
			//Point controlLoc = this.PointToScreen(buttonTip.Location);
			//Point pozicijaKursora = new Point(controlLoc.X + 25, controlLoc.Y + 35);
			//Cursor.Position = pozicijaKursora;

			timerDemo.Start();
		}

		private void panelMapa_DragOver(object sender, DragEventArgs e)
		{
			if (prevuciSaMape)
			{
				Type testTip = new PictureBox().GetType();
				if (e.Data.GetDataPresent(testTip))        // da li je poslata kontrola odgovarajuceg tipa
				{
					e.Effect = DragDropEffects.Move;        // potvrda drag&dropa
				}
				else
				{
					e.Effect = DragDropEffects.None;        // zabrana drag&drop
				}
			}
		}

		private void obriToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripDropDownItem item = sender as ToolStripDropDownItem;
			if (item != null)
			{
				Tuple<Point, PictureBox> tuple = (Tuple<Point, PictureBox>)item.Owner.Tag;
				panelMapa.Controls.Remove(tuple.Item2);

				foreach (KeyValuePair<TreeNode, List<Point>> entry in sve_pozicije)
				{
					foreach (Point p in entry.Value)
					{
						if (p == tuple.Item1)
						{
							Console.WriteLine("Obrisao sam vrstu iz pozicijaaaa!");
							entry.Value.Remove(p);
							return;
						}
					}
				}
			}
		}
		private FormTip otvorenDijalog = null;
		private void timerDemo_Tick(object sender, EventArgs e)
		{
			timerDemo.Stop();

			if (demoMode)
			{
				otvorenDijalog = new FormTip(this);
				otvorenDijalog.Show();

				timerUnesTipa.Start();
			}        
		}
		public Boolean IsDemoMode()
		{
			return demoMode;
		}
		private void timerUnesTipa_Tick(object sender, EventArgs e)
		{
			otvorenDijalog.postaviKursor();
			timerUnesTipa.Stop();
		}
		public void NormalanMode()
		{
			poruka.Visible = false;
			panelMapa.BackColor = Color.FromArgb(255, 255, 192);
			treeView1.BackColor = Color.White;
			//if (demoMode)
			//{
			//	otvorenDijalog.DialogResult = DialogResult.OK;
				//otvorenDijalog.Close();
				demoMode = false;
			//}
		}

		private void formMain_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (demoMode)
			{
				NormalanMode();
				return;
			}
		}

		private void treeView1_MouseClick(object sender, MouseEventArgs e)
		{
			if (demoMode)
			{
				NormalanMode();
				return;
			}
		}

		private void buttonTip_Click(object sender, EventArgs e)
		{

		}

		private void treeView1_Click(object sender, EventArgs e)
		{
			if (demoMode)
			{
				NormalanMode();
				return;
			}
		}

		private void formMain_KeyDown(object sender, KeyEventArgs e)
		{
			if (demoMode)
			{
				NormalanMode();
				return;
			}
		}

		private void menuStrip1_MouseClick(object sender, MouseEventArgs e)
		{
			if (demoMode)
			{
				NormalanMode();
				return;
			}
		}
    }
}
