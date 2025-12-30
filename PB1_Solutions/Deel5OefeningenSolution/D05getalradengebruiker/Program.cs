namespace D05getalradengebruiker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomGetal = random.Next(1, 101);
            int gok = 0;
            try
            {
                do
                {
                    Console.Write("Wat gok je? ");
                    gok = int.Parse(Console.ReadLine());
                    if (gok < randomGetal) Console.WriteLine("Hoger!");
                    else if (gok > randomGetal) Console.WriteLine("Lager!");
                    else
                    {
                        Console.WriteLine("Disco!");
                        break;
                    }

                } while (gok != randomGetal);
            }
            catch
            {
                Console.WriteLine("Er ging iets mis. Probeer opnieuw.");
            }
        }
    }
}
