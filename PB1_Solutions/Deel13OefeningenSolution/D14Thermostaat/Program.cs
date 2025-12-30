namespace D14Thermostaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thermometer thermometer = new Thermometer(17.9);
            Console.WriteLine($"{thermometer.Temperatuur:f2}");

            thermometer.BewerkTemperatuur(-2.9);
            Console.WriteLine($"{thermometer.Temperatuur:f2}");

            thermometer.BewerkTemperatuur(5.2);
            Console.WriteLine($"{thermometer.Temperatuur:f2}");
        }
    }
}
