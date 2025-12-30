namespace D10toonvierkant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToonVierkant();
        }

        static void ToonVierkant()
        {
            for(int i = 0; i < 5; i++)
            {
                ToonLijn();
            }
        }

        static void ToonLijn()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
            }
            Console.Write($"\n");
        }
    }
}
