namespace D11charcount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = 'o';
            Console.Write("Geef een tekst : ");
            string input = Console.ReadLine();


            Console.WriteLine($"'{character}' komt {GetCharCount(input, character)} keer voor");
        }

        static int GetCharCount(string input, char character)
        {
            int aantal = 0;

            foreach (char c in input)
            {
                if (c == char.ToLower(character) || c == char.ToUpper(character))
                {
                    aantal++;
                }
            }
            return aantal;
        }
    }
}
