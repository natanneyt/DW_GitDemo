namespace D10faculteit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = 3;
            Console.WriteLine($"{getal}! is {GetFaculteit(getal)}.");
        }

        static double GetFaculteit(int getal)
        {
            double faculteit = 1;

            for(int i = 1; i <= getal; i++)
            {
                faculteit *= i;
            }
            return faculteit;
        }
    }
}
