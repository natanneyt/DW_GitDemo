namespace D10temperatuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de temperatuur in graden Fahrenheit : ");
            string fahrenheitAlsTekst = Console.ReadLine();
            double fahrenheit = double.Parse(fahrenheitAlsTekst);

            double celsius = ConvertFahrenheitToCelsius(fahrenheit);

            Console.WriteLine("De temperatuur is " + celsius + " graden Celsius.");
        }

        static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
             return 5.0 / 9 * (fahrenheit - 32);
        }
    }
}
