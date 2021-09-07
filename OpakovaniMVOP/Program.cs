using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpakovaniMVOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Clovek adam = new Clovek();
            Clovek david = new Clovek("david", "tlusty");

            Obcan vojtech = new Obcan("000000/0000", "Vojtech", "Pejsar");

            Console.WriteLine(adam.Jmeno + " " + adam.Prijmeni);
            Console.WriteLine(david.Jmeno + " " + david.Prijmeni);
            Console.WriteLine(vojtech.RodneCislo + " " + vojtech.Jmeno + " " + vojtech.Prijmeni);

            Console.ReadLine();
        }
    }
}
