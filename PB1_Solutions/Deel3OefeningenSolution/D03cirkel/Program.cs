namespace D03cirkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is de straal van de cirkel?");
            double straal = double.Parse(Console.ReadLine());
            double omtrek = 2 * Math.PI * straal;
            double oppervlakte = Math.PI * Math.Pow(straal,2);
            Console.WriteLine($"De cirkel heeft een omtrek van {omtrek} en een oppervlakte van {oppervlakte}.");
        }
    }
}
