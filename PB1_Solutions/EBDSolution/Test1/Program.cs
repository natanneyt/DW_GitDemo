namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.WriteLine(new string(' ', Console.WindowWidth));
            }
        }
    }
}
