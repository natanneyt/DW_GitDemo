namespace D12kapitaalwelafgerond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double startkapitaal = VraagInvoer("Startkapitaal");
            double interestvoet = VraagInvoer("Interestvoet (in %)");
            int aantalJaar = 20;
            GeefAfgerondKapitaal(startkapitaal, interestvoet, aantalJaar);
        }

        static double VraagInvoer(string label)
        {
            while (true)
            {
                Console.Write($"{label}: ");
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch { }
            }
        }
        static void GeefAfgerondKapitaal(double startkapitaal, double interestvoet, int aantalJaar)
        {
            double huidigKapitaal = startkapitaal;
            for (int i = 0; i <= aantalJaar; i++)
            {
                huidigKapitaal = Math.Round(huidigKapitaal, 2);
                Console.WriteLine($"Jaar {i}: {huidigKapitaal}");
                huidigKapitaal += huidigKapitaal * interestvoet / 100;
            }
        }
    }
}
