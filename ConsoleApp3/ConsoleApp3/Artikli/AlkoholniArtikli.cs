using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Razredi;

namespace ConsoleApp3.Artikli
{
    class Pivo : AlkoholnoPice
    {
        public Pivo(string _Op, int _Kol, double _Cij, double _Vol, double _Alk) : base(_Op, _Kol, _Cij, _Vol, _Alk)
        {
        }
        public override string Opis()
        {
            return base.Opis();
        }
    }
    class Zestice : AlkoholnoPice
    {
        public Zestice (string _Op, int _Kol, double _Cij, double _Vol, double _Alk) : base(_Op, _Kol, _Cij, _Vol, _Alk)
        {
            this.volumen = volumen * 1000;
        }
        public override string Opis()
        {
            return base.Opis();
        }
    }
    class Vina : AlkoholnoPice
    {
        public Vina (string _Op, int _Kol, double _Cij, double _Vol, double _Alk) : base(_Op, _Kol, _Cij, _Vol, _Alk)
        {
            
        }
        public override string Opis()
        {
            return base.Opis();
        }
    }
}
