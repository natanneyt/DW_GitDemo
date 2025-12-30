namespace D09toongetallenmetjoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = { 4, 7, 9, 34, 2, 56, 34, 78 };

            foreach(int i in getallen)
            {
                if(Array.IndexOf(getallen, i) == getallen.Length - 1) Console.Write(i);
                else Console.Write($"{i}, ");
            }
        }
    }
}
