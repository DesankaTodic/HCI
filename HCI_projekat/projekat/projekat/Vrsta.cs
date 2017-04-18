using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace projekat
{
     [Serializable]
    public class Vrsta
    {
        
        public string ID
        {
            get;
            set;
        }

        public string Ime
        {
            get;
            set;
        }
        public string Opis
        {
            get;
            set;
        }
        public string Tip
        {
            get;
            set;
        }
        public string StatusUgrozenosti
        {
            get;
            set;
        }
        public string Opasna
        {
            get;
            set;
        }
        public string CrvenaLista
        {
            get;
            set;
        }
        public string NaseljeniRegion
        {
            get;
            set;
        }
        public string TuristickiStatus
        {
            get;
            set;
        }
        public int GodisnjiPrihod
        {
            get;
            set;
        }
        public string DatumOtkrivanja
        {
            get;
            set;
        }
        public Image Img
        {
            get;
            set;
        }
        public List<Etiketa> etikete = null;

		public TreeNode treeNode = null;

        public Vrsta(string ID, string ime, string opis, string tip, string statusUgrozenosti, string opasna, string crvenaLista,
            string naseljeniRegion, string turistickiStatus, int godisnjiPrihod, string datumOtkrivanja,Image img)
        {
            this.ID = ID;
            Ime = ime;
            Opis = opis;
            Tip = tip;
            StatusUgrozenosti = statusUgrozenosti;
            Opasna = opasna;
            CrvenaLista = crvenaLista;
            NaseljeniRegion = naseljeniRegion;
            TuristickiStatus = turistickiStatus;
            GodisnjiPrihod = godisnjiPrihod;
            DatumOtkrivanja = datumOtkrivanja;
            Img = img;
            etikete = new List<Etiketa>();
        }
    }
}
