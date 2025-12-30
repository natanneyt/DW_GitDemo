namespace D04prijsappels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aantal kilo aan te kopen appels: ");
            int aantalAppels = int.Parse(Console.ReadLine());
            double prijsPerAppel;

            if (aantalAppels < 10) prijsPerAppel = 3;
            else if (aantalAppels >= 10 && aantalAppels < 20) prijsPerAppel = 2.5;
            else prijsPerAppel = 2;

            double totalePrijs = aantalAppels * prijsPerAppel;
            Console.WriteLine($"Voor {aantalAppels} appels betaal je {totalePrijs} (aan {prijsPerAppel} euro per appel)");
        }
    }
}
