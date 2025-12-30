namespace D02getalontleden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Geef een getal: 123
            // Het getal 123 bestaat uit
            // 1 x 100
            // 2 x  10
            // 3 x   1

            Console.WriteLine("Geef een getal tussen 0 en 999");
            int getal = int.Parse(Console.ReadLine());
            double honderdtal = getal / 100;
            double tiental = (getal % 100)/10;
            double rest = getal % 10;
            Console.WriteLine($"Honderdtallen: {honderdtal}, Tientallen: {tiental}, Rest: {rest}");
        }
    }
}
