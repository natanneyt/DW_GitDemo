namespace D16zoektermenachteraan
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
                Console.WriteLine(string.Join(':', zoekHistoriek));

                Console.Write("Zoekterm: ");
                string invoer = Console.ReadLine();

                zoekHistoriek.RemoveAt(0);
                zoekHistoriek.Add(invoer);
            }
        }
    }
}
