namespace D10printreeks
{
    internal class Program
    {
        static void Main()
        {
            PrintReeks(10, 15);
            PrintReeks(8, 3);
            PrintReeks(4, 4);
        }

        static void PrintReeks(int getal1, int getal2)
        {
            int min, max = 0;
            SorteerGetallen(getal1, getal2, out min, out max);

            for(int i = min; i <= max; i++)
            {
                Console.Write(i);
                if (i < max) Console.Write(" > ");
            }
            Console.WriteLine("");
        }

        static void SorteerGetallen(int getal1, int getal2, out int min, out int max)
        {
            if (getal1 >= getal2)
            {
                min = getal2;
                max = getal1;
            }
            else
            {
                min = getal1;
                max = getal2;
            }
        }
    }
}
