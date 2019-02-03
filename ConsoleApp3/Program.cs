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

            KaficBarflay Barfly  = new KaficBarflay();
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

            Console.WriteLine("\nArtikli u skladistu: \n**********************************");
            Barfly.VratiSkaladiste();

            Console.ReadLine();
        }

    }
}
