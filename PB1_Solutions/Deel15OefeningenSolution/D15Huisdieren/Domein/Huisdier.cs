namespace D15Huisdieren.Domein
{
    internal class Huisdier
    {
        private string _naam;

        public string Naam 
        { 
            get 
            { 
                return _naam;
            } 
            set 
            { 
                _naam = value;
            } 
        }
        private string _soort;

        public string Soort
        {
            get
            {
                return _soort;
            }
            set
            {
                _soort = value;
            }
        }

        private int _leeftijd;
        public int Leeftijd
        {
            get
            {
                return _leeftijd;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Een dier kan geen negatieve leeftijd hebben.");
                else _leeftijd = value;
            }
        }

        public Huisdier(string naam, string soort, int leeftijd)
        {
            Naam = naam;
            Soort = soort;
            Leeftijd = leeftijd;
        }

        public override string ToString()
        {
            return $"{Naam} is een {Soort} van {Leeftijd} jaar";
        }
    }
}
