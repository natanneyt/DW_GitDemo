namespace D07zoeken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een stuk tekst:");
            string tekst = Console.ReadLine().Trim().ToLower();
            Console.Write("Geef een zoekwoord: ");
            string zoekwoord = Console.ReadLine().Trim().ToLower();

            int aantalKeerInTekst = 0;

            for (int i = 0; i < tekst.Length - (zoekwoord.Length - 1); i++)
            {
                for (int k = 0; k < zoekwoord.Length; k++)
                {
                    if (tekst[i + k] != zoekwoord[k]) break;
                    else if(zoekwoord.Length == k + 1) aantalKeerInTekst++;
                }
            }

            Console.WriteLine($"Het zoekwoord komt {aantalKeerInTekst} keer voor.");
        }
    }
}
