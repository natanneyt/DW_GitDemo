namespace D07karakterperpositie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een stuk tekst:");
            string tekst = Console.ReadLine();

            for (int i = 0; i < tekst.Length; i++)
            {
                Console.WriteLine($"{i, 2:d0} = {tekst[i]}");
            }
        }
    }
}
