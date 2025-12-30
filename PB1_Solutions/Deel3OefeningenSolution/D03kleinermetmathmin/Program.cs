using System.ComponentModel.Design;

namespace D03kleinermetmathmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een geheel getal");
            int getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef nog een geheel getal");
            int getal2 = int.Parse(Console.ReadLine());
            if (getal1 == getal2) Console.WriteLine("De getallen zijn even groot.");
            else
            {
                int kleinsteGetal = Math.Min(getal1, getal2);
                Console.WriteLine($"{kleinsteGetal} is het kleinste.");
            }
        }
    }
}
