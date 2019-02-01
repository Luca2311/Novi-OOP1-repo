using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Artikli;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pivo CrnaMala = new Pivo("Ljepotica na jezeru test pivce",1,15,0.5,5.5);
            Console.WriteLine(CrnaMala.Opis());



            Console.ReadLine();
        }
    }
}
