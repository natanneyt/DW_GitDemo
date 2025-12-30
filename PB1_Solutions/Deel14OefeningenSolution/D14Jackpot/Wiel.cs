namespace D14Jackpot
{
    internal class Wiel
    {
        public int Getal { get; set; } = 0;

        public Wiel() { }

        public void Draai()
        {
            Random random = new Random();
            Getal = random.Next(0, 10);
        }
    }
}
