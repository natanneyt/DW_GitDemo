namespace D16zoektermenvooraan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> zoekHistoriek = new List<string>();
            zoekHistoriek.Add("Charlie Sheen");
            zoekHistoriek.Add("Hot shots");
            zoekHistoriek.Add("Winning");
            zoekHistoriek.Add("Electrabel storing");
            zoekHistoriek.Add("Geen elektriciteit");

            while (true)
            {
                for (int i = zoekHistoriek.Count - 1; i >= 0 ; i--)
                {
                    if (i != zoekHistoriek.Count - 1) Console.Write($":{zoekHistoriek[i]}");
                    else Console.Write(zoekHistoriek[i]);
                }

                Console.Write($"\nZoekterm: ");
                string invoer = Console.ReadLine();

                zoekHistoriek.RemoveAt(0);
                zoekHistoriek.Add(invoer);
            }
        }
    }
}
