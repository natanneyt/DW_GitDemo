namespace D04schrikkeljaar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Jaar: ");
            int jaar = int.Parse(Console.ReadLine());
            bool isSchrikkeljaar = false;

            if (jaar % 400 == 0) isSchrikkeljaar = true;
            else if (jaar % 4 == 0 && !(jaar % 100 == 0)) isSchrikkeljaar = true;

            if (isSchrikkeljaar) Console.WriteLine("Dit is een schrikkeljaar.");
            else Console.WriteLine("Dit is geen schrikkeljaar.");
        }
    }
}
