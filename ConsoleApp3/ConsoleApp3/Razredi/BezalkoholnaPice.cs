using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Razredi
{
    class BezalkoholnaPice:Pice
    {
        public BezalkoholnaPice(string opis,int kolicina,double cijena ):base(opis,kolicina,cijena)
        {
        }

        public override string Opis()
        {
            return base.Opis();
        }
    }
}
