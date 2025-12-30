namespace D15Opleidingen.Domein
{
    internal class Opleiding
    {
        public string Naam { get; set; }

        private int _studiepunten;

        public int Studiepunten
        {
            get
            {
                return _studiepunten;
            }
            set
            {
                if (value < 60 || value > 300) throw new ArgumentException("Dit is geen geldig aantal studiepunten");
                else _studiepunten = value;
            }
        }

        public Opleiding(string naam, int studiepunten)
        {
            Naam = naam;
            Studiepunten = studiepunten;
        }

        public override string ToString()
        {
            return $"{Naam} met {Studiepunten} studiepunten";
        }

    }
}
