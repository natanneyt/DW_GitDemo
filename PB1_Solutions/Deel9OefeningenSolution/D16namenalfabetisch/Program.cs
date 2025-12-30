namespace D16namenalfabetisch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> namen = new List<string>();
            do
            {
                Console.Write($"Naam {namen.Count + 1}: ");
                string invoer = Console.ReadLine().Trim();
                if (invoer == "") break;

                namen.Add(invoer);
            } while (true);

            namen.Sort();
            foreach(string naam in namen)
            {
                Console.WriteLine(naam);
            }
        }
    }
}
