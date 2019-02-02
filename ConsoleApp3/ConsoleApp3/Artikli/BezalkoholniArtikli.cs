using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Razredi;

namespace ConsoleApp3.Artikli
{
    class Kava : BezalkoholnaPice
    {
        public Kava(string _Op, int _Kol, double _Cij) : base(_Op, _Kol, _Cij)
        {
        }
        public override string Opis()
        {
            return base.Opis()+"\n";
        }
    }
    class Cappuccino : BezalkoholnaPice
    {
        public Cappuccino(string _Op, int _Kol, double _Cij) : base(_Op, _Kol, _Cij )
        {
        }
        public override string Opis()
        {
            return base.Opis()+"\n";
        }
    }
    class Sok : BezalkoholnaPice
    {
        private string vrsta; 
        public Sok (string _Op, int _Kol, double _Cij, string _Vrsta) : base(_Op, _Kol, _Cij)
        {
            this.vrsta = _Vrsta;
        }
        public override string Opis()
        {
            return base.Opis()+
             String.Format("Vrsta soka:{0}\n\n",vrsta);
        }
    }
}
