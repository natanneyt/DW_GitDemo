namespace D18WerkenMetDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> producten = new Dictionary<string, decimal> { { "product1", 1 }, { "product2", 2 }, { "product3", 3 }, { "product4", 4 }, { "product5", 5 } };

            //string productnaam = "product3";
            //producten.TryGetValue(productnaam, out decimal prijs3);
            //Console.WriteLine($"{productnaam}: {prijs3}");

            producten["product3"] = 4;

            foreach (string productnaam in producten.Keys)
            {
                producten.TryGetValue(productnaam, out decimal prijs);
                Console.WriteLine($"{productnaam}: {prijs}");
            }

            string gezochtProduct = "product6";
            if (producten.ContainsKey(gezochtProduct)) Console.WriteLine($"{gezochtProduct} komt voor in de lijst.");
            else Console.WriteLine($"{gezochtProduct} komt niet voor in de lijst.");
        }
    }
}
