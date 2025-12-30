namespace D05tafelsvan7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int factor = 7;
            do
            {
                Console.WriteLine($"{i} x {factor} = {i * factor}");
                i++;
            } while (i <= 10);
        }
    }
}
