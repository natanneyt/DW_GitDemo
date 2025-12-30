namespace D15Bibliotheek
{
    internal class Bibliotheek
    {
        public List<Boek> Boeken { get; private set; } = new List<Boek>();

        public Bibliotheek() { }

        public void VoegBoekToe(Boek boek)
        {
            Boeken.Add(boek);
        }

        public int GeefAantalBoeken()
        {
            return Boeken.Count;
        }
    }
}
