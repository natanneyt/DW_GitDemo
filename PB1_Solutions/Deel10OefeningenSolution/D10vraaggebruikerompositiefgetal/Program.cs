namespace D10vraaggebruikerompositiefgetal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int breedte = VraagGeheelGetalGroterDan("breedte", 1);
            int hoogte = VraagGeheelGetalGroterDan("hoogte", 1);

            ToonRechthoek(breedte, hoogte);
        }

        static int VraagGeheelGetalGroterDan(string label, int getal)
        {
            bool gelukt = false;
            int waarde = 0;
            do
            {
                try
                {
                    Console.Write($"{label}: ");
                    waarde = int.Parse(Console.ReadLine());
                    if (waarde < getal)
                    {
                        gelukt = false;
                        Console.WriteLine($"De waarde van {label} moet minstens 1 zijn, probeer opnieuw.");
                        continue;
                    }
                    else gelukt = true;
                }
                catch
                {
                    Console.WriteLine("Verkeerde invoer, probeer opnieuw");
                    gelukt = false;
                }
            } while (!gelukt);
            return waarde;
        }

        static void ToonRechthoek(int lengte, int hoogte)
        {
            for (int i = 0; i < hoogte; i++)
            {
                ToonLijn(lengte);
            }
        }

        static void ToonLijn(int lengte)
        {
            for (int i = 0; i < lengte; i++)
            {
                Console.Write("*");
            }
            Console.Write($"\n");
        }
    }
}
