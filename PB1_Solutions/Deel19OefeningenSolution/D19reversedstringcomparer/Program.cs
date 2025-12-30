using D19reversedstringcomparer.Domein;

namespace D19reversedstringcomparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> woorden = new List<string> { "kAT", "Aap", "kat", "HOND", "varken", "zebra", "hondshaai", "aap", "grinch", "varkenshaasje", "hond", "rothond" };

            woorden.Sort();
            Console.WriteLine(string.Join(", ", woorden));
            woorden.Sort(new ReversedStringComparer());
            Console.WriteLine(string.Join(", ", woorden));
        }
    }
}
