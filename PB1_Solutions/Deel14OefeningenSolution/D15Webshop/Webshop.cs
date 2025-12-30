namespace D15Webshop
{
    internal class Webshop
    {
        public List<Bestelling> Bestellingen { get; private set; } = new List<Bestelling>();

        public Webshop() { }

        public void VoegBestellingToe(Bestelling bestelling)
        {
            Bestellingen.Add(bestelling);
        }
    }
}
