namespace D15Winkel
{
    internal class Winkel
    {
        public List<Product> Producten { get; private set; } = new List<Product>();

        public Winkel() { }

        public void VoegProductToe(Product product)
        {
            Producten.Add(product);
        }

        public double BerekenTotaleWaarde()
        {
            double totaleWaarde = 0;
            foreach(Product p in Producten)
            {
                totaleWaarde += p.Prijs;
            }
            return totaleWaarde;
        }
    }
}
