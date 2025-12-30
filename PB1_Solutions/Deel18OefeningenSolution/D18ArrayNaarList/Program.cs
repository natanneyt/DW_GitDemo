namespace D18ArrayNaarList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namen = { "Alice", "Bob", "Charlie" };
            List<string> namenlijst = new List<string>(namen);
            namenlijst.Add("Jimmy");
            namenlijst.Add("Burt");
            namenlijst.Remove("Charlie");
            foreach(string naam in namenlijst)
            {
                Console.WriteLine($"Index {namenlijst.IndexOf(naam)}: {naam}.");
            }
        }
    }
}
