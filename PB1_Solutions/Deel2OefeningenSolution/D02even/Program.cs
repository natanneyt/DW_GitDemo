namespace D02even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een geheel getal");
            int getal = int.Parse(Console.ReadLine());
            if ((getal % 2) == 0) Console.WriteLine("Dit is een even getal");
            else Console.WriteLine("Dit is een oneven getal.");
        }
    }
}
