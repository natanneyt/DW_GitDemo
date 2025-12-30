namespace D12kortingplusbtw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bedragExclBTW = VraagDouble("een bedrag excl. BTW (2 cijfers na de komma)");
            double kortingProcent = VraagDouble("de korting (in %)");
            double btw = VraagDouble("het BTW-tarief (in %)");

            double korting = Math.Round(bedragExclBTW * kortingProcent / 100,2,MidpointRounding.AwayFromZero);
            double btwPrijs = Math.Round((bedragExclBTW - korting) * btw / 100,2,MidpointRounding.AwayFromZero);

            string[] labels = { "excl. BTW", "korting", "BTW", "incl. BTW" };
            double[] waarden = { bedragExclBTW, korting, btwPrijs, Math.Round(bedragExclBTW - korting + btwPrijs,2,MidpointRounding.AwayFromZero) };
            SchrijfResultaat(labels, waarden);
        }

        static double VraagDouble(string label)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Geef {label}: ");
                    double input = double.Parse(Console.ReadLine());
                    if (input >= 0 && input <= 1000000) return input;
                }
                catch
                {
                    Console.WriteLine("Er liep iets mis. Probeer opnieuw.");
                }
            }
        }
        static void SchrijfResultaat(string[] labels, double[] waarden)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                double waarde = double.Parse($"{Math.Round(waarden[i],2,MidpointRounding.AwayFromZero)}");
                Console.WriteLine($"{labels[i],15}{waarde,8}");
            }
        }
    }
}