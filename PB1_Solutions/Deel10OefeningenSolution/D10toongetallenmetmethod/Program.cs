namespace D10toongetallenmetmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = { 4, 7, 9, 34, 2, 56, 34, 78 };
            ToonGetallen(getallen);
        }

        static void ToonGetallen(int[] getallen)
        {
            foreach(int getal in getallen)
            {
                if (Array.IndexOf(getallen, getal) != getallen.Length - 1) Console.Write($"{getal}, ");
                else Console.Write(getal);
            }
        }
    }
}
