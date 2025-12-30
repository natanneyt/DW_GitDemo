namespace D10toonvierkantparameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToonVierkant(5);
        }

        static void ToonVierkant(int zijde)
        {
            for (int i = 0; i < zijde; i++)
            {
                ToonLijn(zijde);
            }
        }

        static void ToonLijn(int zijde)
        {
            for (int i = 0; i < zijde; i++)
            {
                Console.Write("*");
            }
            Console.Write($"\n");
        }
    }
}
