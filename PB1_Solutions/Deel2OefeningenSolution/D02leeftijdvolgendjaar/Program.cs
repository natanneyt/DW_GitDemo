namespace D02leeftijdvolgendjaar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je naam: ");
            string naam = Console.ReadLine();
            Console.Write("Geef je leeftijd: ");
            int leeftijdVolgendJaar = int.Parse(Console.ReadLine()) + 1;
            Console.WriteLine($"Oei oei {naam}, volgend jaar ben je al {leeftijdVolgendJaar} jaar oud!");
        }
    }
}
