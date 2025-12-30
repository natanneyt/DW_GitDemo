namespace D02gemiddelde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef drie kommagetallen");
            double kommagetal1 = double.Parse(Console.ReadLine());
            double kommagetal2 = double.Parse(Console.ReadLine());
            double kommagetal3 = double.Parse(Console.ReadLine());

            double gemiddelde = (kommagetal1 + kommagetal2 + kommagetal3)/ 3;
            Console.WriteLine($"Het gemiddelde van de kommagetallen is {gemiddelde}");
        }
    }
}
