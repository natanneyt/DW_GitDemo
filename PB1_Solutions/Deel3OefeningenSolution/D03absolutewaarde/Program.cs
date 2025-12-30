namespace D03absolutewaarde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal");
            double getal = double.Parse(Console.ReadLine());
            double absoluutGetal = Math.Abs(getal);
            Console.WriteLine($"De absolute waarde van {getal} is {absoluutGetal}");
        }
    }
}
