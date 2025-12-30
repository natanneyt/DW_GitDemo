namespace D15Webshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Webshop webshop = new Webshop();


            try
            {
                Klant klant1 = new Klant("");
                Bestelling bestelling = new Bestelling(klant1, 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Klant klant2 = new Klant("NAAM1");
                Bestelling bestelling = new Bestelling(klant2, -5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Klant klant3 = new Klant("NAAM2");
            Klant klant4 = new Klant("NAAM3");
            Klant klant5 = new Klant("NAAM4");

            Bestelling bestelling1 = new Bestelling(klant3, 2.45);
            Bestelling bestelling2 = new Bestelling(klant4, 1.09);
            Bestelling bestelling3 = new Bestelling(klant5, 29.99);

            webshop.VoegBestellingToe(bestelling1);
            webshop.VoegBestellingToe(bestelling2);
            webshop.VoegBestellingToe(bestelling3);

            Console.WriteLine(webshop.Bestellingen.Count);
        }
    }
}
