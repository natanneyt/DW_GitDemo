namespace D09langstewoord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een stuk tekst in.");
            string invoer = Console.ReadLine();
            string[] woorden = invoer.Split(' ');

            Console.WriteLine($"Aantal woorden: {woorden.Length}");

            if (woorden.Length > 0)
            {
                string langsteWoord = woorden[0];

                foreach (string woord in woorden)
                    if (woord.Length > langsteWoord.Length) langsteWoord = woord;

                Console.WriteLine($"Langste woord: {langsteWoord}");
            }
        }
    }
}
