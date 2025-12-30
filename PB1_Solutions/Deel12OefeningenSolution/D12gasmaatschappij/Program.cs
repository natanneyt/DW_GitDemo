using System.ComponentModel.Design;

namespace D12gasmaatschappij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beginstand = 0;
            int eindstand = 0;
            int maxGetal = 1000000;
            decimal eersteDuizendPrijs = 0.34m;
            decimal restPrijs = 0.31m;

            bool isBeginstandJuist = false;
            while (true)
            {
                try
                {
                    if (!isBeginstandJuist)
                    {
                        Console.Write("Beginstand: ");
                        beginstand = int.Parse(Console.ReadLine());
                        isBeginstandJuist = true;
                    }
                    Console.Write("Eindstand: ");
                    eindstand = int.Parse(Console.ReadLine());
                    break;
                }
                catch { }
            }
            int verbruik = 0;
            decimal prijs = 0;

            if (eindstand < beginstand)
            {
                verbruik = maxGetal - beginstand + eindstand;
            }
            else verbruik = eindstand - beginstand;

            if (verbruik > 1000)
            {
                prijs = (1000m * eersteDuizendPrijs) + ((verbruik - 1000m) * restPrijs);
            }
            else prijs = verbruik * eersteDuizendPrijs;


                Console.WriteLine($"De totale kostprijs is {prijs} EUR.");
        }
    }
}
