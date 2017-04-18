using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace projekat
{
     [Serializable]
    public class Etiketa
    {
        public string ID
        {
            get;
            set;
        }

        public Color Boja
        {
            get;
            set;
        }
        public string Opis
        {
            get;
            set;
        }
		public Vrsta vrsta = null;
        public Etiketa(string ID, Color boja, string Opis)
        {
            this.ID = ID;
            this.Boja = boja;
            this.Opis = Opis;
        }
    }
}
