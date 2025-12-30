using System.ComponentModel;

namespace D10toonrechthoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int breedte = VraagWaarde("breedte");
            int hoogte = VraagWaarde("hoogte");

            ToonRechthoek(breedte, hoogte);
        }

        static int VraagWaarde(string label)
        {
            bool gelukt = false;
            int waarde = 0;
            do
            {
                try
                {
                    Console.Write($"{label}: ");
                    waarde = int.Parse(Console.ReadLine());
                    if (waarde < 1)
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
