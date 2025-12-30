namespace D07achterstevoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een stuk tekst:");
            string tekst = Console.ReadLine();

            for(int i = 0; i < tekst.Length; i++)
            {
                Console.Write($"{tekst[tekst.Length - 1 - i]}");
            }
        }
    }
}
