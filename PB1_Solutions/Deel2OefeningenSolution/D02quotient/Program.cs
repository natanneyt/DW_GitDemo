namespace D02quotient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een deeltal.");
            double deeltal = double.Parse(Console.ReadLine());
            Console.WriteLine("Geef een deler.");
            double deler = double.Parse(Console.ReadLine());

            if (deler == 0) Console.WriteLine("Deling door 0 wordt niet toegelaten.");
            else Console.WriteLine(deeltal / deler);
        }
    }
}
