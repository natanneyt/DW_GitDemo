namespace D14Kluis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kluis kluis = new Kluis(9989);

            Console.WriteLine($"{kluis.IsOpen}");

            kluis.OpenKluis(4553);

            Console.WriteLine($"{kluis.IsOpen}");

            kluis.OpenKluis(9989);

            Console.WriteLine($"{kluis.IsOpen}");

            kluis.SluitKluis();

            Console.WriteLine($"{kluis.IsOpen}");
        }
    }
}
