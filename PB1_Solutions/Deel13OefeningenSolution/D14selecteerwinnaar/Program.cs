namespace D14selecteerwinnaar
{
    internal class Program
    {
        // "Jan", "Eric", "Wim", "Geert", "Johan"
        static void Main(string[] args)
        {
            Persoon[] personen = new Persoon[] { new Persoon("Jan"), new Persoon("Eric"), new Persoon("Wim"), new Persoon("Geert"), new Persoon("Johan") };
            Console.WriteLine($"De winnaar is {SelecteerWinnaar(personen).Naam}");
        }

        static Persoon SelecteerWinnaar(Persoon[] personen)
        {
            Random randomGetal = new Random();

            return personen[randomGetal.Next(0, personen.Length)];
        }
    }
}
