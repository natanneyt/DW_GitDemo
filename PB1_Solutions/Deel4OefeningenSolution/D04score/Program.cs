namespace D04score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Score (in %): ");
            double scoreInProcent = double.Parse(Console.ReadLine());
            string scoreLetter = "A";

            if (scoreInProcent > 82) scoreLetter = "A";
            else if (scoreInProcent > 67 && scoreInProcent <= 82) scoreLetter = "B";
            else if (scoreInProcent > 52 && scoreInProcent <= 67) scoreLetter = "C";
            else if (scoreInProcent > 37 && scoreInProcent <= 52) scoreLetter = "D";
            else if (scoreInProcent > 22 && scoreInProcent <= 37) scoreLetter = "E";
            else scoreLetter = "F";

            Console.WriteLine($"Your score of {scoreInProcent}% translates to the score {scoreLetter}");
        }
    }
}
