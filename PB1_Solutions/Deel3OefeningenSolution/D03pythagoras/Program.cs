namespace D03pythagoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is de basis van de driehoek?");
            double basis = double.Parse(Console.ReadLine());

            Console.WriteLine("Wat is de hoogte van de driehoek?");
            double hoogte = double.Parse(Console.ReadLine());

            double schuineZijde = Math.Sqrt(basis*basis + hoogte*hoogte);
            Console.WriteLine($"De lengte van de schuine zijde is {schuineZijde}");
        }
    }
}
