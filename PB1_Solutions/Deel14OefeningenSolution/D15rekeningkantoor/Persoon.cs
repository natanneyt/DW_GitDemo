namespace D15rekeningkantoor
{
    internal class Persoon
    {
        public string Voornaam { get; set; }
        
        public string Achternaam { get; set; }

        public Adres Adres { get; set; }

        public Persoon(string voornaam, string achternaam, Adres adres)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Adres = adres;
        }
    }
}
