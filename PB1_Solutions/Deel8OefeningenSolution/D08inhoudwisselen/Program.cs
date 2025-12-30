namespace D08inhoudwisselen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 34, 56, 78, 90 };
            int[] b = { 31, 42, 53, 64, 75 };
            int[] c = new int[a.Length];

            Console.Write("De inhoud van a voor de wissel : ");
            Console.WriteLine(String.Join(',', a));

            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
                a[i] = b[i];
                b[i] = c[i];
            }

            Console.Write("De inhoud van a na de wissel : ");
            Console.WriteLine(String.Join(',', a));
        }
    }
}
