namespace D11concataantalkeer
{
    internal class Program
    {
        static void Main()
        {
            string output = ConcatAantalKeer("*-", 4);
            Console.WriteLine(output);
        }

        static string ConcatAantalKeer(string input, int aantal)
        {
            string resultaat = "";
            for (int i = 0; i < aantal; i++)
            {
                resultaat += input;
            }
            return resultaat;
        }
    }
}
