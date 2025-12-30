namespace D04bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lengte ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("in ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("cm: ");
            double lengteInCm = double.Parse(Console.ReadLine());
            double lengteInM = lengteInCm / 100.0;

            Console.Write("Gewicht ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("in ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("kg: ");
            double gewicht = double.Parse(Console.ReadLine());

            double bmi = gewicht / Math.Pow(lengteInM, 2);

            if (bmi < 18.5) Console.WriteLine($"BMI: {bmi} (ondergewicht)");
            else if (bmi >= 18.5 && bmi < 25) Console.WriteLine($"BMI: {bmi} (normaal gewicht)");
            else if (bmi >= 25 && bmi < 30) Console.WriteLine($"BMI: {bmi} (overgewicht)");
            else if (bmi >= 30 && bmi < 40) Console.WriteLine($"BMI: {bmi} (zwaarlijvigheid)");
            else Console.WriteLine($"BMI {bmi} (ernstige zwaarlijvigheid)");
        }
    }
}
