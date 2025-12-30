namespace D03kleinermetif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een geheel getal");
            int getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef nog een geheel getal");
            int getal2 = int.Parse(Console.ReadLine());

            if (getal1 < getal2) Console.WriteLine($"{getal1} is kleiner.");
            else if (getal2 < getal1) Console.WriteLine($"{getal2} is kleiner");
            else Console.WriteLine("De nummers zijn even groot.");
        }
    }
}
