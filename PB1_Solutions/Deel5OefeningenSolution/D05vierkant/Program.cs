namespace D05vierkant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Zijde?: ");
                int zijde = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;

                int breedteTeller = 0;
                int hoogteTeller = 0;

                do
                {
                    do
                    {
                        Console.Write("*");
                        breedteTeller++;
                    } while (breedteTeller < zijde);

                    hoogteTeller++;
                    breedteTeller = 0;
                    Console.WriteLine("");

                } while (hoogteTeller < zijde);

                Console.ForegroundColor = ConsoleColor.White;
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
