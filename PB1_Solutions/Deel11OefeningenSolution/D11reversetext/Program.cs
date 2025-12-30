namespace D11reversetext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een stuk tekst:");
            string invoer = Console.ReadLine();
            string omgekeerdeTekst = ReverseInvoer(invoer);
            Console.WriteLine(omgekeerdeTekst);
        }

        static string ReverseInvoer(string invoer)
        {
            string omgekeerdeTekst = "";
            for (int i = invoer.Length - 1; i >= 0; i--)
            {
                omgekeerdeTekst += invoer[i];
            }
            return omgekeerdeTekst;
        }
    }
}
