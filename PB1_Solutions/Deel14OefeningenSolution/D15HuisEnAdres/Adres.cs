using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15HuisEnAdres
{
    internal class Adres
    {
        public string Straat { get; set; }

        public int Huisnummer {  get; set; }

        public Adres(string straat, int huisnummer)
        {
            Straat = straat;
            Huisnummer = huisnummer;
        }

        public override string ToString()
        {
            return $"{Straat} {Huisnummer}";
        }
    }
}
