namespace D08omgekeerdevolgorde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aantalNamen = 4;
            string[] namen = new string[aantalNamen];

            for (int i = 0; i < aantalNamen; i++)
            {
                Console.Write("Geef een naam: ");
                namen[i] = Console.ReadLine().Trim().ToLower();
            }

            for (int i = namen.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(namen[i]);
            }
        }
    }
}
