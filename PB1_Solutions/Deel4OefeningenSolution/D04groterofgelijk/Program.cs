namespace D04groterofgelijk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            double getal1 = double.Parse(Console.ReadLine());

            Console.Write("Geef een tweede getal: ");
            double getal2 = double.Parse(Console.ReadLine());

            if (getal1 > getal2) Console.WriteLine($"Het eerste getal ({getal1}) is groter.");
            else if (getal2 > getal1) Console.WriteLine($"Het tweede getal ({getal2}) is groter.");
            else Console.WriteLine($"De getallen zijn even groot.");
        }
    }
}
