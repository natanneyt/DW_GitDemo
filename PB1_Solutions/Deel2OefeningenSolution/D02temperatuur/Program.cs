namespace D02temperatuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef de temperatuur in Fahrenheit.");
            double temperatuurInFahrenheit = double.Parse(Console.ReadLine());
            double temperatuurInCelsius = 5.0 / 9.0 * (temperatuurInFahrenheit - 32.0);
            Console.WriteLine($"De temperatuur in Celsius is {temperatuurInCelsius}");
        }
    }
}
