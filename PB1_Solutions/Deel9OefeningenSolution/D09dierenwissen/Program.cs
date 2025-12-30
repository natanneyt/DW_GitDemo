namespace D09dierenwissen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };

            do
            {
                foreach (string dier in boerderijDieren)
                {
                    if (dier != null) Console.Write($"{dier} "); 
                    else Console.Write("GEWIST ");
                }

                Console.Write($"\nWelk dier wil je verwijderen? ");
                string invoer = Console.ReadLine().ToLower().Trim();

                if(boerderijDieren.Contains(invoer))
                {
                    boerderijDieren[Array.IndexOf(boerderijDieren, invoer)] = null;
                }
            } while (true);
        }
    }
}
