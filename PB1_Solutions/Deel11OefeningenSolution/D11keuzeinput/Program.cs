namespace D11keuzeinput
{
    internal class Program
    {
        static void Main()
        {
            string[] keuzes = { "Rood", "Groen", "Blauw" };
            int index = GetKeuze(keuzes);
            string kleur = keuzes[index];
            Console.WriteLine($"U koos {kleur}");
        }

        static int GetKeuze(string[] keuzes)
        {
            while (true)
            {
                Console.Write($"Geef uw keuze ({String.Join('|', keuzes)}: ");
                string invoer = Console.ReadLine().Trim().ToLower();

                foreach(string keuze in keuzes)
                {
                    if(invoer == keuze.ToLower())
                    {
                        return Array.IndexOf(keuzes, keuze);
                    }
                }
            }
        }
    }
}
