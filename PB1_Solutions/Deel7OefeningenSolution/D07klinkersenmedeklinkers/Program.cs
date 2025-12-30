namespace D07klinkersenmedeklinkers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een stuk tekst in:");
            string tekst = Console.ReadLine().Trim().ToLower();

            string klinkers = "aeiou";
            string medeklinkers = "bcdfghjklmnpqrstvwxyz";

            int aantalKlinkers = 0;
            int aantalMedeklinkers = 0;

            foreach(char c in tekst)
            {
                if (klinkers.Contains(c)) aantalKlinkers++;
                else if (medeklinkers.Contains(c)) aantalMedeklinkers++;
            }
            Console.WriteLine($"{aantalKlinkers} klinker(s) en {aantalMedeklinkers} medeklinker(s)");
        }
    }
}
