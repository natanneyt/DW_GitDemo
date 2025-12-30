namespace D09zoekdier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };

            Console.Write("Geef een boerderijdier: ");
            string invoer = Console.ReadLine().Trim().ToLower();
            bool isBoerderijDier = false;

            foreach(string dier in boerderijDieren)
            {
                if (invoer == dier)
                {
                    Console.WriteLine("Dit is een boerderijdier.");
                    isBoerderijDier = true;
                    break;
                }
            }
            if(!isBoerderijDier) Console.WriteLine("Dit is geen boerderijdier.");
        }
    }
}
