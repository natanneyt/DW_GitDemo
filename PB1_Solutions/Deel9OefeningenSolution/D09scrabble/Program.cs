namespace D09scrabble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een woord in: ");
            string woord = Console.ReadLine().Trim().ToLower();
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] scores = { 1, 3, 5, 2, 1, 4, 3, 4, 1, 4, 3, 3, 3, 1, 1, 3, 10, 2, 2, 2, 4, 4, 5, 8, 8, 4 };
            int som = 0;
            int iteratie = 0;

            foreach(char c in woord)
            {
                if (iteratie != 0) Console.Write("+");
                else Console.Write("Dat woord is ");

                int index = Array.IndexOf(letters, c);
                int score = scores[index];
                som += score;
                Console.Write(score);
                iteratie++;
            }
            Console.Write($"={som} punten waard.");
        }
    }
}