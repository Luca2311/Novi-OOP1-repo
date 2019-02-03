using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Razredi
{
    class Kupac
    {
        private double novci = 0;
        private Pice kaPice;
        public void KupiPice(Pice pice,int kolici)
        {
            this.kaPice = pice;
            pice.ZadajKolicinuKupljenog(kolici);
        }

        public Kupac(double pare)
        {
            novci = pare;
        }

        public Pice VratiKuPice()
        {
            return kaPice;
        }




    }
}
