namespace D04toelage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // geen toelage indien jaarinkomen groter dan 20000 OF minder dan 3 kinderen
            Console.Write("Jaarinkomen: ");
            int jaarinkomen = int.Parse(Console.ReadLine());
            Console.Write("Aantal kinderen: ");
            int aantalKinderen = int.Parse(Console.ReadLine());
            double toelageFactor = 0.03;
            if (jaarinkomen > 20000 || aantalKinderen < 3) toelageFactor = 0;
            double toelage = jaarinkomen * toelageFactor;
            double totaalInkomen = jaarinkomen + toelage;
            Console.WriteLine($"Toelage: {toelage}, totaal inkomen: {totaalInkomen}");
        }
    }
}
