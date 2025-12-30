namespace D10toonsomtussen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToonSomTussen(0,65);
        }

        static int ToonSomTussen(int min, int max)
        {
            int som = 0;

            for(int i = min; i <= max; i++)
            {
                Console.WriteLine($"{som} + {i} = {som + i}");
                som += i;
            }

            return som;
        }
    }
}
