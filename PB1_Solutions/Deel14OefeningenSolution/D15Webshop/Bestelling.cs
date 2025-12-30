namespace D15Webshop
{
    internal class Bestelling
    {
        public Klant Klant { get; set; }

        private double _bedrag;

        public double Bedrag
        {
            get
            {
                return _bedrag;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Getal mag niet negatief zijn.");
                else _bedrag = value;
            }
        }

        public Bestelling(Klant klant, double bedrag)
        {
            Klant = klant;
            Bedrag = bedrag;
        }
    }
}
