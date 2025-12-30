namespace D07beginmethoofdletters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een stuk tekst:");
            string tekst = Console.ReadLine().Trim().ToLower();
            string tekstMetHoofdletters = tekst.ToUpper(); ;
            int aantalHoofdletters = 5;

            for(int i = 0; i < tekst.Length; i++)
            {
                if (i < aantalHoofdletters) Console.Write(tekstMetHoofdletters[i]);
                else Console.Write(tekst[i]);
            }

        }
    }
}
