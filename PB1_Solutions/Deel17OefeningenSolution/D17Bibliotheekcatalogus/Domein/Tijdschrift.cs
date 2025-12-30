namespace D17Bibliotheekcatalogus.Domein
{
    internal class Tijdschrift : Publicatie
    {
        public string Editie { get; set; }

        public Tijdschrift(string titel, int jaar,string editie) : base(titel, jaar)
        {
            Editie = editie;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Titel} - {Jaar} - {Editie}";
        }
    }
}
