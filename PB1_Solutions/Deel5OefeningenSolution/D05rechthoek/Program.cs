namespace D05rechthoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Hoogte?: ");
                int hoogte = int.Parse(Console.ReadLine());

                Console.Write("Breedte?: ");
                int breedte = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;

                int breedteTeller = 0;
                int hoogteTeller = 0;

                do
                {
                    do
                    {
                        Console.Write("*");
                        breedteTeller++;
                    } while (breedteTeller < breedte);

                    hoogteTeller++;
                    breedteTeller = 0;
                    Console.WriteLine("");

                } while (hoogteTeller < hoogte);

                Console.ForegroundColor = ConsoleColor.White;
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
