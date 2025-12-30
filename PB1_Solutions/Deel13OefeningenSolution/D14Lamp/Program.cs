namespace D14Lamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lamp lamp = new Lamp("blauw", true);

            Console.WriteLine($"{lamp.Kleur}, {lamp.IsAan}");

            lamp.ZetUit();
            Console.WriteLine($"{lamp.Kleur}, {lamp.IsAan}");

            lamp.ZetAan();
            Console.WriteLine($"{lamp.Kleur}, {lamp.IsAan}");
        }
    }
}
