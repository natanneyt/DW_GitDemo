namespace D16vijfkleinstegetallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> getallen = new List<int>();
            while (getallen.Count < 10)
            {
                try
                {
                    Console.Write("Geef een getal in: ");
                    string invoer = Console.ReadLine();
                    int getal = int.Parse(invoer);
                    getallen.Add(getal);
                }
                catch 
                { 
                    Console.WriteLine("Ongeldige input.");
                }
            }
            for (int i = 0; i < 10; i++)
            {

            }
            getallen.Sort();
            Console.WriteLine("De vijf kleinste getallen zijn ");
            for (int i = 0; i < 5; i++) Console.Write($"{getallen[i]} ");
        }
    }
}
