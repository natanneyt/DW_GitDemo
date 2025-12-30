namespace D06rechthoekopmaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Lengte: ");
                int lengte = int.Parse(Console.ReadLine());

                Console.Write("Hoogte: ");
                int hoogte = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;

                for (int i = 0; i < hoogte; i++)
                {
                    for (int k = 0; k < lengte; k++)
                    {
                        Console.Write("*");
                    }
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
