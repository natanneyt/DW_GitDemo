namespace D14rechthoek
{
    class Program
    {
        static void Main()
        {        
            // Maak een instantie van een Rechthoek aan
            Rechthoek rechthoek = new Rechthoek(4.1, 8);
            PrintRechthoek(rechthoek);

            // Pas de breedte en hoogte van de rechthoek aan
            rechthoek.Hoogte = 5;
            rechthoek.Breedte = 10.2;

            PrintRechthoek(rechthoek);

            try
            {
                rechthoek = new Rechthoek(-5, 7);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Er liep iets fout: {ex.Message}");
            }
        }

        static void PrintRechthoek(Rechthoek r)
        {
            Console.WriteLine($"Rechthoek met hoogte {r.Hoogte}, breedte {r.Breedte} en oppervlakte {r.Oppervlakte}.");
        }
    }
}
