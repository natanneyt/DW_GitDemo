namespace D05hiephieperhiepstrobuust
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leeftijd = 0;
            do
            {
                Console.Write("Hoe oud wordt de jarige : ");
                string invoer = Console.ReadLine();
                try
                {
                    leeftijd = int.Parse(invoer);
                    if( leeftijd < 1)
                    {
                        Console.WriteLine("Dit is een ongeldige leeftijd. Probeer opnieuw.");
                        continue;
                    }
                    break;
                    
                }
                catch
                {
                    Console.WriteLine("Dit is een ongeldige leeftijd. Probeer opnieuw.");
                }
            } while (true);

            int jaar = 1;
            while (jaar <= leeftijd)
            {
                Console.WriteLine("Hiep hiep hiep, hoera!");
                if (jaar != leeftijd) Console.WriteLine("Nog een keer!");
                jaar++;
            }
        }
    }
}
