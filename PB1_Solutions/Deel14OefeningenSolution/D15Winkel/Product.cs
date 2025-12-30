namespace D15Winkel
{
    internal class Product
    {
        private string _naam = "";

        public string Naam 
        { 
            get
            {
                return _naam;
            }
            set
            {
                if (value.Trim().Length == 0) throw new ArgumentException("De naam moet karakters bevatten die geen spaties zijn.");
                else _naam = value;
            }
        }

        private double _prijs;

        public double Prijs 
        {
            get
            {
                return _prijs;
            }
            set
            {
                if (value < 0) throw new ArgumentException("De prijs mag niet negatief zijn.");
                else _prijs = value;
            }
        }

        public Product(string naam, double prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }
    }
}
