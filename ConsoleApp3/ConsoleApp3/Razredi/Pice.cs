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

        public virtual  string Opis()
        {
            return String.Format(
                "Pice:{0},\n" +
                "Cijena:{1}kn,\n" +
                "Kolicina:{2},\n" 
                ,
                opis,cijena,kolicina);
        }
    }
}
