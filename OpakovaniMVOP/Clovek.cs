using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpakovaniMVOP
{
    class Clovek
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }

        public Clovek()
        {
            Jmeno = "nezname";
            Prijmeni = "nezname";
        }

        public Clovek(string _jmeno, string  _prijmeni)
        {
            Jmeno = _jmeno;
            Prijmeni = _prijmeni;
        }
    }
}
