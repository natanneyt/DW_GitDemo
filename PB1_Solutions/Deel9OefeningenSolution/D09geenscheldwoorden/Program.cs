namespace D09geenscheldwoorden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] scheldwoorden = { "bedrijfspoedel", "boerenheikneuter", "doos", "ezelsveulen", "galgenbrok", "gluipsnor", "huzarenhoop", "karpatenkop", "kloefkapper", "kloothommel" };

            Console.WriteLine("Geef een stuk tekst in: ");
            string invoer = Console.ReadLine().ToLower().Trim();
            bool bevatScheldwoorden = false;
            foreach(string s in scheldwoorden)
            {
                if (invoer.Contains(s)) bevatScheldwoorden = true;
            }
            if (bevatScheldwoorden) Console.WriteLine("Dit is geen aanvaarde tekst.");
            else Console.WriteLine("Deze tekst bevat geen scheldwoorden.");
        }
    }
}
