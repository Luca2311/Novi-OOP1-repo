using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Artikli;
using ConsoleApp3.Razredi;

namespace ConsoleApp3
{
    class Program
    {
        static double racunKraj = 0;
        static KaficBarflay Barfly = new KaficBarflay();

        static void Main(string[] args)
        {
            
            
            //izradimo pica koja zelimo u skladistu
            Pivo zuja = new Pivo("Ozujsko", 30, 15, 0.5, 5.2);
            Pivo karlovacko = new Pivo("Karlovacko", 15, 14, 0.5, 4.9);
            Pivo lasko = new Pivo("Lasko", 18, 14, 0.5, 4.2);
            Kava kava = new Kava("Kavica", 150, 8);
            Cappuccino cap = new Cappuccino("Classic", 80, 10);
            Sok Coca = new Sok("CocaCola", 200, 12, "gazirani");
            Sok cedevita = new Sok("Cedevita", 50, 10, "negazirani");
            Vina crveno = new Vina("Crveno vino", 70, 150, 1, 13.5);
            Vina bijelo = new Vina("Bijelo vino", 50, 130, 1, 11.5);
            Zestice kratki = new Zestice("Zestica", 200, 10, 0.05, 40.1);

            Barfly.DodajUskladiste(zuja);
            Barfly.DodajUskladiste(karlovacko);
            Barfly.DodajUskladiste(lasko);
            Barfly.DodajUskladiste(kava);
            Barfly.DodajUskladiste(cap);
            Barfly.DodajUskladiste(Coca);
            Barfly.DodajUskladiste(cedevita);
            Barfly.DodajUskladiste(crveno);
            Barfly.DodajUskladiste(bijelo);
            Barfly.DodajUskladiste(kratki);

            Console.WriteLine("Artikli u skladistu: \n**********************************");
            Barfly.VratiSkaladiste();

            Kupac Darko = new Kupac(500);
            Darko.KupiPice(kava, 3);
            Barfly.OduzmiOdSkladista(Darko.VratiKuPice(), kava.VratiKolicinuKupljenog());
            Darko.KupiPice(kratki, 10);
            Barfly.OduzmiOdSkladista(Darko.VratiKuPice(), kratki.VratiKolicinuKupljenog());
            Darko.KupiPice(crveno, 1);
            Barfly.OduzmiOdSkladista(Darko.VratiKuPice(), crveno.VratiKolicinuKupljenog());
            Darko.KupiPice(cedevita, 15);
            Barfly.OduzmiOdSkladista(Darko.VratiKuPice(), cedevita.VratiKolicinuKupljenog());
            Darko.KupiPice(kava, 7);
            Barfly.OduzmiOdSkladista(Darko.VratiKuPice(), kava.VratiKolicinuKupljenog());


            Console.WriteLine("\nArtikli u skladistu nakon kupnje: \n**********************************");
            Barfly.VratiSkaladiste();

            racunKraj += Barfly.izlazRacunPoPicu();

            Console.WriteLine("\nOvo je vas racun\n************************\n");
            Console.WriteLine(Racun());
            Console.ReadLine();
        }

        static string Racun()
        {
            return String.Format("Kafic: {0}\nCijena: {1} kn", nameof(Barfly), racunKraj);
        }
    }
}
