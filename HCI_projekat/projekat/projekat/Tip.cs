using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace projekat
{
    [Serializable]
    public class Tip
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
        public Image Img
        {
            get;
            set;
        }
        public List<Vrsta> vrste;
        public Tip(string ID, string Ime, string Opis,Image img)
        {
            this.ID = ID;
            this.Ime = Ime;
            this.Opis = Opis;
            Img = img;
            vrste = new List<Vrsta>();
        }
    }
}
