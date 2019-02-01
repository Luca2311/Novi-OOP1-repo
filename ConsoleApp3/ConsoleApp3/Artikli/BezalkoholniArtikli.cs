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
            return base.Opis();
        }
    }
    class Cappuccino : BezalkoholnaPice
    {
        public Cappuccino(string _Op, int _Kol, double _Cij) : base(_Op, _Kol, _Cij )
        {
            this.volumen = volumen * 1000;
        }
        public override string Opis()
        {
            return base.Opis();
        }
    }
    class Sok : BezalkoholnaPice
    {
        private string vrsta; 
        public Sok (string _Op, int _Kol, double _Cij, string _Vrsta) : base(_Op, _Kol, _Cij)
        {
            this.volumen = volumen * 10;
        }
        public override string Opis()
        {
            return base.Opis();
        }
    }
}
