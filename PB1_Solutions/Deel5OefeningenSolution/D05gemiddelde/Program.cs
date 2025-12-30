namespace D05gemiddelde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            int aantal = 0;
            double gemiddelde = 0;

            try
            {
                do
                {
                    Console.Write("Geef een getal in: ");
                    int getal = int.Parse(Console.ReadLine());
                    if (getal != -1)
                    {
                        som += getal;
                        aantal++;
                    }
                    else
                    {
                        gemiddelde = som / aantal;
                        Console.WriteLine($"Het gemiddelde van de gegeven getallen is {gemiddelde}.");
                        break;
                    }
                } while (true);
            }
            catch
            {
                Console.WriteLine("Dit was geen geldig getal");
            }
        }
    }
}
