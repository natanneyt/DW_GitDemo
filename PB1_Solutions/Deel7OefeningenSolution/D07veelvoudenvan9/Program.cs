namespace D07veelvoudenvan9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factor = 9;
            for (int i = 1; i <= 15; i+=2)
            {
                int vermenigvuldiging = i * factor;
                Console.WriteLine($"{i,2:d0} x {factor} = {vermenigvuldiging, 3:d0}");
            }
        }
    }
}
