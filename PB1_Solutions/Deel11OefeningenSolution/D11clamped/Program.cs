namespace D11clamped
{
    internal class Program
    {
        // getal indien min <= getal && getal <= max

        // bv.GetClamped(5, 8, 15) produceert 8

        // min indien getal<min

        // bv.GetClamped(5, 2, 15) produceert 5

        // max indien getal > max

        //bv.GetClamped(5, 33, 15) produceert 15
        static void Main()
        {
            Console.WriteLine("Voorbeeld GetClamped met min=3 en max=6");
            for (int i = 1; i <= 8; i++)
            {
                int clamped = GetClamped(3, i, 6);
                Console.WriteLine($"voor {i} geeft dit {clamped}");
            }
        }

        static int GetClamped(int min, int getal, int max)
        {
            if (min <= getal && getal <= max) return getal;
            else if (getal < min) return min;
            else return max;
        }
    }
}
