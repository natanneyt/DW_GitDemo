namespace D12bertbevermettimespan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ticksPerMilliseconde = (int)TimeSpan.TicksPerMillisecond;
            Console.WriteLine("Druk 2x na elkaar op dezelfde toets, zo snel mogelijk..");

            char c1 = Console.ReadKey(true).KeyChar;
            DateTime datum1 = DateTime.Now;

            char c2 = Console.ReadKey(true).KeyChar;
            DateTime datum2 = DateTime.Now;

            if (c1 == c2)
            {
                TimeSpan ts = datum2 - datum1;

                Console.WriteLine($"De tijd ertussen bedroeg {ts.Milliseconds}ms");
            }
            else
            {
                Console.WriteLine("Dat waren 2 verschillende toetsen!");
            }
        }
    }
}
