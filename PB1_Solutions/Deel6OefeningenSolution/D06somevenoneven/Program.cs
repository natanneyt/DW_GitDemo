using System.ComponentModel.Design;

namespace D06somevenoneven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int aantalEvenGetallen = 0;
                int aantalOnevenGetallen = 0;
                int somEvenGetallen = 0;
                int somOnevenGetallen = 0;

                int getal = 0;

                while (true)
                {
                    Console.Write("Geef een getal (negatief om te stoppen): ");
                    try
                    {
                        getal = int.Parse(Console.ReadLine());
                    }
                    catch 
                    {
                        continue;
                    }

                    if(getal < 0)
                    {
                        Console.WriteLine($"Aantal even getallen: {aantalEvenGetallen}\n" +
                            $"Aantal oneven getallen: {aantalOnevenGetallen}\n" +
                            $"Som even getallen: {somEvenGetallen}\n" +
                            $"Som oneven getallen: {somOnevenGetallen}");
                        break;
                    }
                    else if (getal % 2 == 0)
                    {
                        aantalEvenGetallen++;
                        somEvenGetallen += getal;
                    }
                    else if (getal % 2 == 1)
                    {
                        aantalOnevenGetallen++;
                        somOnevenGetallen += getal;
                    }
                };
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
