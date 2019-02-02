using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Razredi
{
    class AlkoholnoPice:Pice
        
    {
        protected double alkohol; 
        public AlkoholnoPice(string _Opis, int _Kolicina, double _Cijena, double _Volumen, double Alkohol) : base(_Opis,_Kolicina,_Cijena)
        {
            this.volumen = _Volumen;
            this.alkohol = Alkohol; //volumen * (alkohol / 100); ovo je ako ocemo znati dal se bude cojvek napio
        }

        public override string Opis()
        {
            return base.Opis() + String.Format("Volumen:{0} litra,\n" +
                "kolicina alkohola {01}%\n\n", volumen,alkohol);

        }


    }
}
