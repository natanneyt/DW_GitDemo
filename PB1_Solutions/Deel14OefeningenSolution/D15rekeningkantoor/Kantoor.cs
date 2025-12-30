namespace D15rekeningkantoor
{
    internal class Kantoor
    {
        public Persoon Kantoorhouder { get; set; }

        public Adres Adres { get; set; }

        public Kantoor(Persoon kantoorhouder, Adres adres)
        {
            Kantoorhouder = kantoorhouder;
            Adres = adres;
        }
    }
}
