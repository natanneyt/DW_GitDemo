namespace D15Webshop
{
    internal class Klant
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

        public Klant(string naam)
        {
            Naam = naam;
        }
    }
}
