namespace D09censuur
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
                        for (int i = 0; i < s.Length; i++)
                        {
                            censuur += "*";
                        }
                        invoer = invoer.Substring(0, robuusteInput.IndexOf(s)) + censuur + invoer.Substring(robuusteInput.IndexOf(s) + s.Length);
                        robuusteInput = invoer.ToLower();
                    }
                }
            } while (bevatScheldwoorden);
            Console.WriteLine(invoer);
        }
    }
}
