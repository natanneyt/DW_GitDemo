namespace D17Bibliotheekcatalogus.Domein
{
    internal class Strip : Publicatie
    {
        public string Illustrator { get; set; }

        public Strip(string titel, int jaar, string illustrator) : base(titel, jaar)
        {
            Illustrator = illustrator;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Titel} - {Jaar} - {Illustrator}";
        }
    }
}
