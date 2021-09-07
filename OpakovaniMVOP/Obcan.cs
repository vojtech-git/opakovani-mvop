using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OpakovaniMVOP
{
    class Obcan : Clovek
    {
        string r_cislo;

        Regex regex = new Regex(@"^\d{6}\/\d{4}$");

        public string RodneCislo
        {

            get
            {
                return r_cislo;
            }
            set
            {
                r_cislo = regex.IsMatch(value) ? value : throw new FormatException("špatný formát rodného čísla");
            }
        }

        public Obcan()
        {
            Jmeno = "nezname";
            Prijmeni = "nezname";
            RodneCislo = "000000/0000";
        }

        public Obcan(string _rodneCislo, string _jmeno, string _prijmeni) : base(_jmeno, _prijmeni)
        {
            RodneCislo = _rodneCislo;
        }
    }
}
