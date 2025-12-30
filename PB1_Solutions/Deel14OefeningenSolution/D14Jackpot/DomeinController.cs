namespace D14Jackpot
{
    internal class DomeinController
    {
        private Jackpot jackpot { get; set; }

        public void StartNieuweJackpot()
        {
            jackpot = new Jackpot();
        }

        public List<int> GeefGetallenVanWielen()
        {
            return jackpot.GeefGetallenVanWielen();
        }

        public void Speel()
        {
            jackpot.Speel();
        }

        public int GeefScore()
        {
            return jackpot.GeefScore();
        }
    }
}
