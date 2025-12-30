using System.Linq.Expressions;

namespace D06simon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string reeks = $"{random.Next(1, 5)}";
            int onthoudTijd = 2;

            try
            {
                while (true)
                {
                    Console.WriteLine($"U hebt {onthoudTijd} seconden om deze code te onthouden: \n{reeks}");

                    Thread.Sleep(2000);
                    Console.Clear();

                    Console.Write("Geef de code: ");

                    string gok = Console.ReadLine();

                    if (gok == reeks)
                    {
                        Console.Clear();

                        reeks = $"{reeks}{random.Next(1, 5)}";
                        continue;
                    }
                    else break;
                }
                ;
                Console.WriteLine($"Helaas, de code was {reeks}");
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
