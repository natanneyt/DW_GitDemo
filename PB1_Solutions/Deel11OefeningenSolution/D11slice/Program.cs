namespace D11slice
{
    internal class Program
    {
        static void Main()
        {
            int[] getallen = { 0, 1, 2, 3, 4, 5, 6 }; // makkelijke getallen om te testen en te debuggen!

            int[] testHead0 = Slice(getallen, 0, 0);
            int[] testMiddle0 = Slice(getallen, 3, 0);
            int[] testTail0 = Slice(getallen, getallen.Length - 1, 0);

            int[] testHead1 = Slice(getallen, 0, 1);
            int[] testMiddle1 = Slice(getallen, 3, 1);
            int[] testTail1 = Slice(getallen, getallen.Length - 1, 1);

            int[] testHead2 = Slice(getallen, 0, 2);
            int[] testMiddle2 = Slice(getallen, 3, 2);
            int[] testTail2 = Slice(getallen, getallen.Length - 2, 2);

            int[] testComplete = Slice(getallen, 0, getallen.Length);

            int[] array = testHead0;

            string output = String.Join("-", array);
            Console.WriteLine(output);
        }

        static int[] Slice(int[] values, int startIndex, int length)
        {
            if (length != 0)
            {
                int currentLength = 0;
                int[] result = new int[length];
                for (int i = startIndex; i < startIndex + length; i++)
                {
                    result[currentLength] = values[i];
                    currentLength++;
                }
                return result;
            }
            else return new int[0];
        }
    }
}
