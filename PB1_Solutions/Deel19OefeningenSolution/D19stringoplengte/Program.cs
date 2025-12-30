using D19stringoplengte.Domein;

namespace D19stringoplengte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> woorden = new List<string> { "grinch", "hond", "kat", "zebra", "aap", "musti" };
            woorden.Sort();
            Console.WriteLine(string.Join(", ", woorden));
            woorden.Sort(new StringLengteComparer());
            Console.WriteLine(string.Join(", ", woorden));
        }
    }
}
