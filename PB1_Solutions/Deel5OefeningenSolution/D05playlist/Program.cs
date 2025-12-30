namespace D05playlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aantal liedjes ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("in ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("playlist: ");

            try
            {
                int aantal = int.Parse(Console.ReadLine());
                int permutaties = 1;
                int huidigeIteratie = 1;
                do
                {
                    permutaties *= huidigeIteratie;
                    huidigeIteratie++;
                } while (huidigeIteratie <= aantal);
                Console.Write($"{aantal} liedjes kan je ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("in ");
                Console.ForegroundColor = ConsoleColor.White;
                if(permutaties > 1) Console.Write($"{permutaties} verschillende volgordes ");
                else Console.Write($"{permutaties} verschillende volgorde ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("in ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("een playlist plaatsen.");
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
