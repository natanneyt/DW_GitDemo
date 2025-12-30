namespace D06sommeer1tem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double som = 0;
            for (int i = 1; i <= 10; i++)
            {
                som += Math.Pow(i, 2);
                Console.WriteLine(som);
            }
        }
    }
}
