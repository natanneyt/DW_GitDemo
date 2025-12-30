namespace D03leeftijdinterpolatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je naam: ");
            string naam = Console.ReadLine();
            Console.Write("Geef je leeftijd: ");
            string leeftijd = Console.ReadLine();
            Console.WriteLine($"Goeiedag {naam}, je bent dus {leeftijd} jaar oud!");
        }
    }
}
