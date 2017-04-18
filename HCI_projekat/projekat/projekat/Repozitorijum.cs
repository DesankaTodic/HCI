using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace projekat
{
    class Repozitorijum
    {
        //private Dictionary<String, Vrsta> _r = new Dictionary<String, Vrsta>();
        private readonly string _datotekaVrsta;
        private readonly string _datotekaTipova;
        private readonly string _datotekaEtiketa;
		private readonly string _datotekaCvorova;
		private readonly string _datotekaPozicija;

        public Repozitorijum()
        {
            _datotekaVrsta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vrste.podaci");
            UcitajDatotekuVrsta();
            _datotekaTipova = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tipovi.podaci");
            UcitajDatotekuTipova();
            _datotekaEtiketa = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "etikete.podaci");
            UcitajDatotekuEtiketa();
			_datotekaCvorova = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cvorovi.podaci");
			UcitajDatotekuCvorova();
			_datotekaPozicija = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lokacije.podaci");
			UcitajDatotekuLokacija();
        }
		public void UcitajDatotekuLokacija()
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = null;

			if (File.Exists(_datotekaPozicija))
			{
				try
				{
					stream = File.Open(_datotekaPozicija, FileMode.Open);
					//Dictionary<TreeNode, Point> pozicije = new Dictionary<TreeNode, Point>();
					formMain.sve_pozicije = (Dictionary<TreeNode, List<Point>>)formatter.Deserialize(stream);



				}
				catch
				{
					// 
				}
				finally
				{
					if (stream != null)
						stream.Dispose();
				}

			}
			else
				formMain.sve_pozicije = new Dictionary<TreeNode, List<Point>>();
		}

		public void UcitajDatotekuCvorova()
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = null;

			if (File.Exists(_datotekaCvorova))
			{
				try
				{
					stream = File.Open(_datotekaCvorova, FileMode.Open);
					formMain.NodesOnMap = (List<TreeNode>)formatter.Deserialize(stream);



				}
				catch
				{
					// 
				}
				finally
				{
					if (stream != null)
						stream.Dispose();
				}

			}
			else
				formMain.NodesOnMap = new List<TreeNode>();
		}
		public void MemorisiDatotekuLokacija()
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = null;

			try
			{
				stream = File.Open(_datotekaPozicija, FileMode.OpenOrCreate);
				formatter.Serialize(stream, formMain.sve_pozicije);

			}
			catch
			{
				// 
			}
			finally
			{
				if (stream != null)
					stream.Dispose();
			}
		}
		public void MemorisiDatotekuCvorova()
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = null;

			try
			{
				stream = File.Open(_datotekaCvorova, FileMode.OpenOrCreate);
				formatter.Serialize(stream, formMain.NodesOnMap);

			}
			catch
			{
				// 
			}
			finally
			{
				if (stream != null)
					stream.Dispose();
			}
		}
        public void MemorisiDatotekuVrsta()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(_datotekaVrsta, FileMode.OpenOrCreate);
                formatter.Serialize(stream, Tabelarni_prikaz_vrste.vrste);
               
            }
            catch
            {
                // 
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }

        public void UcitajDatotekuVrsta()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(_datotekaVrsta))
            {
                try
                {
                    stream = File.Open(_datotekaVrsta, FileMode.Open);
                    Tabelarni_prikaz_vrste.vrste = (List<Vrsta>)formatter.Deserialize(stream);
                    
                }
                catch
                {
                    // 
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }

            }
            else
                Tabelarni_prikaz_vrste.vrste = new List<Vrsta>();
                
        }
        public void MemorisiDatotekuTipova()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(_datotekaTipova, FileMode.OpenOrCreate);
                formatter.Serialize(stream, Tabelarni_prikaz_tipa.tipovi);

            }
            catch
            {
                // 
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }

        public void UcitajDatotekuTipova()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(_datotekaTipova))
            {
                try
                {
                    stream = File.Open(_datotekaTipova, FileMode.Open);
                    Tabelarni_prikaz_tipa.tipovi = (List<Tip>)formatter.Deserialize(stream);

                }
                catch
                {
                    // 
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }

            }
            else
                Tabelarni_prikaz_tipa.tipovi = new List<Tip>();

        }
        public void MemorisiDatotekuEtiketa()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(_datotekaEtiketa, FileMode.OpenOrCreate);
                formatter.Serialize(stream, Tabelarni_prikaz_etikete.etikete);

            }
            catch
            {
                // 
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }

        public void UcitajDatotekuEtiketa()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(_datotekaEtiketa))
            {
                try
                {
                    stream = File.Open(_datotekaEtiketa, FileMode.Open);
                    Tabelarni_prikaz_etikete.etikete = (List<Etiketa>)formatter.Deserialize(stream);

                }
                catch
                {
                    // 
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }

            }
            else
                Tabelarni_prikaz_etikete.etikete = new List<Etiketa>();

        }
        //public Dictionary<Guid, Osoba> getAll()
        //{
        //    return _r;
        //}
    }
}
