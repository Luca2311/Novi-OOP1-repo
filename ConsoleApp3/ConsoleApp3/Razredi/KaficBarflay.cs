using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Razredi
{
    
    class KaficBarflay
    {
        protected List<Pice> ListaPica = new List<Pice>();
        private double racun = 0;

        public void DodajUskladiste(Pice pijaca)
        {
            ListaPica.Add(pijaca);
        }

        public void VratiSkaladiste()
        {
            if (ListaPica.Count > 0)
            {
                foreach (Pice p in ListaPica)
                {
                    Console.Write(p.Opis());
                }
            }
            else
            {
                Console.WriteLine("Skladiste je prazno");
            }
        }

        

        public void OduzmiOdSkladista(Pice pice, int kolicina)
        {
            string a = pice.VratiImePica();
            int kol1 = pice.VratiKolicinu();
            foreach (Pice p in ListaPica)
            {
                string b = p.VratiImePica();
                if (a==b)
                {
                    kol1 -= p.VratiKolicinuKupljenog();
                    racun += (p.VratiKolicinuKupljenog() * p.VratiCijenu());

                }
            }

            pice.NovaKolicina(kol1);
        }

        public double izlazRacunPoPicu()
        {
            return racun;
        }
        


    }
}
