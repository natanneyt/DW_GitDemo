namespace D12bertbeverzondertimespan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Druk 2x op dezelfde toets");

            DateTime tijdEen = DateTime.Now;
            ConsoleKeyInfo toets1 = Console.ReadKey(true);

            DateTime tijdTwee = DateTime.Now;
            ConsoleKeyInfo toets2 = Console.ReadKey(true);

            long ticks = tijdTwee.Ticks - tijdEen.Ticks;
            Console.WriteLine(ticks);
            if (toets1.Key != toets2.Key) Console.WriteLine("Dit waren twee verschillende toetsen.");
            else Console.WriteLine(ticks/10000l);
        }
    }
}
