namespace D05driehoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Rechthoekzijde?: ");
                int zijde = int.Parse(Console.ReadLine());

                int lengte = zijde;

                Console.ForegroundColor = ConsoleColor.Red;

                int breedteTeller = 0;

                do
                {
                    do
                    {
                        Console.Write("*");
                        breedteTeller++;
                    } while (breedteTeller < lengte);

                    breedteTeller = 0;
                    lengte--;
                    Console.WriteLine("");

                } while (lengte > 0);

                Console.ForegroundColor = ConsoleColor.White;
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
