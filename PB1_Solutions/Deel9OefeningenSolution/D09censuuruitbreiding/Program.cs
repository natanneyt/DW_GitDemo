namespace D09censuuruitbreiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] scheldwoorden = { "bedrijfspoedel", "boerenheikneuter", "doos", "ezelsveulen", "galgenbrok", "gluipsnor", "huzarenhoop", "karpatenkop", "kloefkapper", "kloothommel" };

            Console.WriteLine("Geef een stuk tekst in: ");
            string invoer = Console.ReadLine();
            string robuusteInput = invoer.ToLower();
            bool bevatScheldwoorden = false;

            do
            {
                bevatScheldwoorden = false;
                foreach (string s in scheldwoorden)
                {
                    if (robuusteInput.Contains(s))
                    {
                        bevatScheldwoorden = true;
                        string censuur = "";
                        for (int i = 0; i < s.Length - 2; i++)
                        {
                            censuur += "*";
                        }
                        invoer = invoer.Substring(0, robuusteInput.IndexOf(s) + 1) + censuur + invoer.Substring(robuusteInput.IndexOf(s) + s.Length - 1);
                        robuusteInput = invoer.ToLower();
                    }
                }
            } while (bevatScheldwoorden);
            Console.WriteLine(invoer);
        }
    }
}
