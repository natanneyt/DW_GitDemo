namespace D08dagnummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] weekdagen = { "Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag" };
                Console.Write("Geef een dagnummer: ");
                int dagnummer = int.Parse(Console.ReadLine());
                string dag = weekdagen[dagnummer - 1];
                Console.Write($"{dagnummer} is {dag}.");

            }
            catch { }
        }
    }
}
