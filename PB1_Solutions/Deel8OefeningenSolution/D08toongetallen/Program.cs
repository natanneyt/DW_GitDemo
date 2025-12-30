namespace D08toongetallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3 };

            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1) Console.Write(a[i]);
                else Console.Write($"{a[i]}, ");
            }
        }
    }
}
