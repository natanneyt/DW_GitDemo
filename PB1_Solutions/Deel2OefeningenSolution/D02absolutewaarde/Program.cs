namespace D02absolutewaarde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal");
            double getal = double.Parse(Console.ReadLine());
            double absoluutGetal = getal;
            if (getal < 0) absoluutGetal = getal * (-1.0);
            Console.WriteLine($"De absolute waarde van {getal} is {absoluutGetal}");
        }
    }
}
