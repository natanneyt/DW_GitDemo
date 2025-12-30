using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15RegisterVanVoertuigen.Domein
{
    internal class Voertuig
    {
        private string _merk;

        public string Merk
        {
            get
            {
                return _merk;
            }
            set
            {
                _merk = value;
            }
        }

        private int _bouwjaar;

        public int Bouwjaar
        {
            get
            {
                return _bouwjaar;
            }
            set
            {
                if (value < 1886) throw new ArgumentException("Dit is geen geldig bouwjaar");
                else _bouwjaar = value;
            }
        }

        private int _aantalDeuren;

        public int AantalDeuren
        {
            get
            {
                return _aantalDeuren;
            }
            set
            {
                if (value < 2 || value > 5) throw new ArgumentException("Dit is geen geldig aantal deuren");
                else _aantalDeuren = value;
            }
        }

        public Voertuig(string merk, int bouwjaar, int aantalDeuren)
        {
            Merk = merk;
            Bouwjaar = bouwjaar;
            AantalDeuren = aantalDeuren;
        }

        public override string ToString()
        {
            return $"{Merk} ({Bouwjaar}) met {AantalDeuren} aantal deuren";
        }
    }
}
