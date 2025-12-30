namespace D15Winkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Winkel winkel = new Winkel();

            try
            {
                Product product = new Product("  ", 12.12);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Product product = new Product("PRODUCTNAAM", -1.35);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Product product1 = new Product("PRODUCTNAAM1", 12.34);
            Product product2 = new Product("PRODUCTNAAM2", 19.99);
            Product product3 = new Product("PRODUCTNAAM3", 12.89);
            Product product4 = new Product("PRODUCTNAAM4", 32.99);
            Product product5 = new Product("PRODUCTNAAM5", 2.49);

            winkel.VoegProductToe(product1);
            winkel.VoegProductToe(product2);
            winkel.VoegProductToe(product3);
            winkel.VoegProductToe(product4);
            winkel.VoegProductToe(product5);

            Console.WriteLine(winkel.BerekenTotaleWaarde());
        }
    }
}
