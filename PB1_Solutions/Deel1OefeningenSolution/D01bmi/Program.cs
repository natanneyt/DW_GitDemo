namespace D01bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lengteInCm = 182;
            double gewichtInKg = 72;

            double lengteInM = lengteInCm / 100;

            double bmi = gewichtInKg / (lengteInM * lengteInM);

            Console.WriteLine(bmi);

        }
    }
}
