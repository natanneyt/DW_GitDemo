namespace D18Teams.Domein
{
    internal class Team
    {
        public string Naam { get; set; }

        public string Competitie { get; set; }

        public HashSet<Speler> Spelers { get; set; } = new HashSet<Speler>();

        public Team(string naam, string competitie)
        {
            Naam = naam;
            Competitie = competitie;
        }

        public override string ToString()
        {
            return $"{Naam} ({Competitie}) - {Spelers.Count} spelers" + GeefSpelerlijst();
        }

        public string GeefSpelerlijst()
        {
            string tekst = "";
            foreach (Speler speler in Spelers)
            {
                tekst += $"\n\t{speler.ToString()} ";
            }
            return tekst;
        }
    }
}
