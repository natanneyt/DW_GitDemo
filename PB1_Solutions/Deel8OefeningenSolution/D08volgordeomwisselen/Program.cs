namespace D08volgordeomwisselen
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
                string[] tempNamen;
                tempNamen = new string[namen.Length];

                for (int i = 0; i < aantalNamen; i++)
                {
                    tempNamen[i] = namen[i];
                }

                for (int i = 0; i < namen.Length; i++)
                {
                    namen[i] = tempNamen[tempNamen.Length - 1 - i];
                }
                foreach (string s in namen)
                    Console.Write($"{s} ");
            }
            catch
            {
                Console.WriteLine("Er ging iets mis.");
            }
        }
    }
}
