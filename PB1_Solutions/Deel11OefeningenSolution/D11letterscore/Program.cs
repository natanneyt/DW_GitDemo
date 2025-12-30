namespace D11letterscore
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Geef de score in % : ");
            string scoreAlsTekst = Console.ReadLine();
            int score = int.Parse(scoreAlsTekst);

            string letter = GetLetterCodeForPercentage(score);

            Console.WriteLine($"In Amerika is dat een \"{letter}\"");
        }

        static string GetLetterCodeForPercentage(int percentage)
        {
            string letter;
            if (percentage > 82)
            {
                letter = "A";
            }
            else if (percentage > 67)
            {
                letter = "B";
            }
            else if (percentage > 52)
            {
                letter = "C";
            }
            else if (percentage > 37)
            {
                letter = "D";
            }
            else if (percentage > 22)
            {
                letter = "E";
            }
            else
            {
                letter = "F";
            }
            return letter;
        }

        
    }
}
