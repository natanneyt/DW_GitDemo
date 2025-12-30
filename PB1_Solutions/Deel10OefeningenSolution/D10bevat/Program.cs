namespace D10bevat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dieren = { "hond", "kat", "olifant", "krokodil" };

            Console.WriteLine(Bevat(dieren, "papegaai"));
            Console.WriteLine(Bevat(dieren, "olifant"));
        }

        static bool Bevat(string[] dieren, string dier)
        {
            return dieren.Contains(dier.ToLower().Trim());
        }
    }
}
