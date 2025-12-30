namespace D07dotdotdot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst in: ");
            string tekst = Console.ReadLine();

            foreach (char c in tekst)
            {
                Console.Write($"{c}.");
            }
        }
    }
}
