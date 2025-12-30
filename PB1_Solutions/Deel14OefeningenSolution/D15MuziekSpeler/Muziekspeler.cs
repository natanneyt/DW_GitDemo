namespace D15MuziekSpeler
{
    internal class Muziekspeler
    {
        public List<Lied> Liedjes { get; private set; } = new List<Lied>();

        public Muziekspeler() { }

        public void VoegLiedToe(Lied lied)
        {
            Liedjes.Add(lied);
        }

        public void SpeelLiedAf(int index)
        {
            Console.WriteLine($"\"{Liedjes[index].Titel}\" speelt nu.");
        }
    }
}
