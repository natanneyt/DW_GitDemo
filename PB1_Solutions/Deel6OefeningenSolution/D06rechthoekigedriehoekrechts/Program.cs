namespace D06rechthoekigedriehoekrechts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Hoogte: ");
                int hoogte = int.Parse(Console.ReadLine());
                int lengte = 1;

                Console.ForegroundColor = ConsoleColor.Red;

                for (int i = 0; i < hoogte; i++)
                {
                    string tekst = "";

                    for (int k = 0; k < hoogte - lengte; k++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < lengte; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine($"{tekst}");
                    lengte++;
                }

                Console.ForegroundColor = ConsoleColor.White;
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
