using D19stringznaara.Domein;

namespace D19stringznaara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> woorden = new List<string> { "kAT", "Aap", "kat", "HOND", "varken", "zebra", "hondshaai", "aap", "grinch", "varkenshaasje", "hond" };
            woorden.Sort();

            Console.Write($"{string.Join(", ", woorden)}\n");
            woorden.Sort(new StringComparerOmgekeerd());
            Console.Write($"{string.Join(", ", woorden)}\n");
        }
    }
}
