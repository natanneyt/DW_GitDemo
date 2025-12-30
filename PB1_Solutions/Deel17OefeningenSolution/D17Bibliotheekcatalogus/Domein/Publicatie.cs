namespace D17Bibliotheekcatalogus.Domein
{
    abstract class Publicatie
    {
        public string Titel { get; set; }

        public int Jaar { get; set; }

        public Publicatie(string titel, int jaar)
        {
            Titel = titel;
            Jaar = jaar;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Titel} - {Jaar}";
        }
    }
}
