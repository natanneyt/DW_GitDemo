using System;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace D04inkomprijs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lengte in cm: ");
            int lengteInCm = int.Parse(Console.ReadLine());

            Console.Write("Leeftijd: ");
            int leeftijd = int.Parse(Console.ReadLine());
            double prijsFactor = 1;
            if (lengteInCm < 160 && leeftijd > 20) prijsFactor = 0.5;

            double ticketprijs = 10 * prijsFactor;
            Console.WriteLine($"De prijs van het ticket is {ticketprijs}");

        }
    }
}
