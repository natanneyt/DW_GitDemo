namespace D12kapitaalnietafgerond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double startkapitaal = VraagInvoer("Startkapitaal");
            double interestvoet = VraagInvoer("Interestvoet (in %)");
            int aantalJaar = 20;
            GeefKapitaal(startkapitaal, interestvoet, aantalJaar);
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
        static void GeefKapitaal(double startkapitaal, double interestvoet, int aantalJaar)
        {
            double huidigKapitaal = startkapitaal;
            for(int i = 0; i <= aantalJaar; i++)
            {
                Console.WriteLine($"Jaar {i}: {huidigKapitaal:f2}");
                huidigKapitaal += huidigKapitaal * interestvoet / 100;
            }
        }
    }
}
