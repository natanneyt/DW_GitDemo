namespace D11minmax
{
    internal class Program
    {
        static void Main()
        {
            int[] getallen = { -4, 7, 9, 34, 2, 56, 34, 78 };
            Console.WriteLine(BepaalMinimum(getallen));
            Console.WriteLine(BepaalMaximum(getallen));
        }

        static int BepaalMinimum(int[] getallen)
        {
            int minimumGetal = getallen[0];

            foreach(int i in getallen)
            {
                if (i < minimumGetal) minimumGetal = i;
            }
            return minimumGetal;
        }

        static int BepaalMaximum(int[] getallen)
        {
            int maximumGetal = getallen[0];

            foreach (int i in getallen)
            {
                if (i > maximumGetal) maximumGetal = i;
            }
            return maximumGetal;
        }
    }
}
