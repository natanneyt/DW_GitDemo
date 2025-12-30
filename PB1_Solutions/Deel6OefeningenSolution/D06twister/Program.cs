using System.ComponentModel.Design.Serialization;

namespace D06twister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Het spel start over 3 seconden...");
            Thread.Sleep(3000);
            Random random = new Random();
            while (true)
            {
                string kleur = random.Next(1,5) switch
                {
                        1 => "rood", 2 => "groen", 3 => "blauw", 4 => "geel", _ => "rood"
                }
                ;
                string lichaamsdeel = random.Next(1, 5) switch
                {
                    1 => "linkerhand",
                    2 => "rechterhand",
                    3 => "linkervoet",
                    4 => "rechtervoet",
                    _ => "linkervoet"
                };
                Console.WriteLine($"{lichaamsdeel} op {kleur}.");
                Thread.Sleep(7000);
            }
        }
    }
}
