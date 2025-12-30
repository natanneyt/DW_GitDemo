namespace D06rechthoekigedriehoeklinks
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
                    for (int k = 0; k < lengte; k++)
                    {
                        Console.Write("*");
                    }
                    lengte++;
                    Console.WriteLine("");
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
