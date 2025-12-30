namespace D02totalebedrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aantal muntstukken van 2 euro: 4
            // Aantal muntstukken van 1 euro: 3
            // Het totale bedrag is 11 Euro.
            Console.Write("Hoeveel muntstukken van 2 euro heb je? ");
            int muntstukken2Euro = int.Parse(Console.ReadLine());
            Console.Write("Hoeveel muntstukken van 1 euro heb je? ");
            int muntstukken1Euro = int.Parse(Console.ReadLine());
            int totaalBedrag = muntstukken1Euro + muntstukken2Euro * 2;
            Console.WriteLine($"Je hebt {totaalBedrag} euro.");
        }
    }
}
