using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Razredi
{
    class Kupac
    {
        private List<Pice> KupljenaPijaca = new List<Pice>();
        private double novci = 0;
        private int kol = 0;
        public void KupiPice(Pice pice,int kolici)
        {
            kol=3;
            KupljenaPijaca.Add(pice);
        }

        public Kupac(double pare)
        {
            novci = pare;
        }

        public void Racun()
        {
            foreach (Pice p in KupljenaPijaca)
            {
                Console.Write(p.Opis());
                //dodali cijenu racuna
            }
        }


    }
}
