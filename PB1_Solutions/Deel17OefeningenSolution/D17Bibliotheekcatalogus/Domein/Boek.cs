namespace D17Bibliotheekcatalogus.Domein
{
    internal class Boek : Publicatie
    {
        public string Auteur { get; set; }

        public Boek(string titel, int jaar, string auteur) : base(titel, jaar)
        {
            Auteur = auteur;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Titel} - {Jaar} - {Auteur}";
        }
    }
}
