using System.Reflection.Metadata.Ecma335;

namespace D14Jackpot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DomeinController controller = new DomeinController();
            controller.StartNieuweJackpot();
            int score = 0;
            bool wilStoppen = false;
            do
            {
                controller.Speel();
                score += controller.GeefScore();
                Console.WriteLine($"| {string.Join(" | ", controller.GeefGetallenVanWielen())} | {$"score: {score}",15}");

                wilStoppen = VraagInputAanGebruiker();
            } while (!wilStoppen);
        }

        static bool VraagInputAanGebruiker()
        {
            while (true)
            {
                try
                {
                    Console.Write($"Geef '1' in om verder te spelen, '0' om te stoppen: ");
                    int invoer = int.Parse(Console.ReadLine().Trim());
                    if (invoer == 1) return false;
                    else if (invoer == 0) return true;
                    else continue;
                }
                catch
                {
                    Console.WriteLine("Er liep iets mis, probeer opnieuw.");
                }
            }
        }
    }
}
