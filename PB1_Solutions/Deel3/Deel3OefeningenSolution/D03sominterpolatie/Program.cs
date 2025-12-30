namespace D03sominterpolatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een geheel getal");
            int getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef nog een geheel getal");
            int getal2 = int.Parse(Console.ReadLine());
            int som = getal1 + getal2;
            Console.WriteLine($"De som van {getal1} en {getal2} is {som}");
        }
    }
}
