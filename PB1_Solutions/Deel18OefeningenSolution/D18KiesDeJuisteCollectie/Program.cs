namespace D18KiesDeJuisteCollectie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scenario A: List<string>
            // Goed als je vaak indices nodig hebt en er veel veranderd moet kunnen worden.
            List<string> namen = new List<string>();
            namen.Add("naam1");
            namen.Add("naam2");
            namen.RemoveAt(namen.IndexOf("naam1"));
            namen[namen.IndexOf("naam2")] = "naam1";
            foreach(string naam in namen)
            {
                Console.WriteLine($"Index {namen.IndexOf(naam)}: {naam}");
            }
            Console.WriteLine();

            // Scenario B: LinkedList<>
            // Ideaal voor taken, waarin de volgorde van elementen heel belangrijk is en indices niet vaak nodig zijn.
            LinkedList<string> taken = new LinkedList<string>();
            taken.AddLast("taak1");
            taken.AddLast("taak2");
            taken.AddLast("taak3");
            taken.AddFirst("taak0");
            taken.Find("taak1").Value = "taak0.5";

            int taakCount = 0;
            foreach (string taak in taken)
            {
                Console.WriteLine($"Index {taakCount}: {taak}");
                taakCount++;
            }
            Console.WriteLine();

            // Scenario C: HashSet<>
            // Ideaal waar orde niet belangrijk is, maar waar ook geen duplicaten mogelijk zijn.
            HashSet<string> emailadressen = new HashSet<string> { "email1", "email2", "email3", "email2", "email3", "email4" };

            int emailCount = 0;
            foreach (string email in emailadressen)
            {
                Console.WriteLine($"Index {emailCount}: {email}");
                emailCount++;
            }
            Console.WriteLine();

            // Scenario D: Dictionary
            // Gebruikt om twee verschillende values aan elkaar te koppelen: hier dus perfect voor prijzen van producten
            Dictionary<string, decimal> producten = new Dictionary<string, decimal> { { "product1", 1 }, { "product2", 2 }, { "product3", 3 } };
            foreach(string productNaam in producten.Keys)
            {
                producten.TryGetValue(productNaam, out decimal prijs);
                Console.WriteLine($"{productNaam} - {prijs}");
            }
        }
    }
}
