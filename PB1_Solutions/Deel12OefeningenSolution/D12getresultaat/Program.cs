namespace D12getresultaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scoresA = { 3, 7, 10 };
            int[] scoresB = { 4, 6, 9 };
            int[] leeg = { };

            Console.WriteLine(GetResultaat(scoresA, scoresB)); // toont negatief getal want speler 1 wint
            Console.WriteLine(GetResultaat(scoresB, scoresA)); // toont positief getal want speler 2 wint
            Console.WriteLine(GetResultaat(scoresA, scoresA)); // toont zero want gelijkspel
            Console.WriteLine(GetResultaat(leeg, leeg)); // toont zero want gelijkspel
        }

        static int GetResultaat(int[] scoresSpeler1, int[] scoresSpeler2)
        {
            int score = 0;
            for(int i = 0; i < scoresSpeler1.Length; i++)
            {
                if (scoresSpeler1[i] > scoresSpeler2[i]) score--;
                else if (scoresSpeler1[i] < scoresSpeler2[i]) score++;
            }
            return score;
        }
    }
}
