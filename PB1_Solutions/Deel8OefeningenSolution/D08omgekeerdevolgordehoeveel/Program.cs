namespace D08omgekeerdevolgordehoeveel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aantal namen: ");
            try
            {
                int aantalNamen = int.Parse(Console.ReadLine());
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
            catch 
            { 
                Console.WriteLine("Er ging iets mis.");
            }
        }
    }
}
