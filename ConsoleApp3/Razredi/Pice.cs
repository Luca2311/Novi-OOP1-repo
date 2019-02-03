using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Razredi
{
    class Pice
    {
        protected double volumen;
        protected double cijena;
        protected int kolicina;
        protected string opis;
        protected int kolicinaKupljenog;

        public Pice(string opis, int kolicina, double cijena)
        {
            this.opis = opis;
            this.kolicina = kolicina;
            this.cijena = cijena;
        }

        public string VratiImePica()
        { return opis; }

        public int VratiKolicinu()
        {
            return kolicina;
        }

        public void NovaKolicina(int novKol)
        {
            this.kolicina = novKol;
        }
        public void ZadajKolicinuKupljenog(int kolKupca)
        {
            this.kolicinaKupljenog = kolKupca;
        }
        public int VratiKolicinuKupljenog()
        {
            return kolicinaKupljenog;
        }

        public double VratiCijenu()
        {
            return cijena;
        }

        public virtual  string Opis()
        {
            return String.Format(
                "Pice:{0},\n" +
                "Cijena:{1}kn,\n" +
                "Kolicina:{2} komada,\n" 
                ,
                opis,cijena,kolicina);
        }
    }
}
