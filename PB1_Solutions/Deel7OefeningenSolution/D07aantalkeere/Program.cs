namespace D07aantalkeere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een stuk tekst:");
            string tekst = Console.ReadLine().ToLower().Trim();
            char karakter = 'e';
            int aantalKeerKarakter = 0;

            foreach(char c in tekst)
            {
                if (c == karakter) aantalKeerKarakter++;
            }
            Console.WriteLine($"Het karakter {karakter} komt {aantalKeerKarakter} keer voor.");
        }
    }
}
