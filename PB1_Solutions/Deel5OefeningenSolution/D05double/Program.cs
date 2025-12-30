namespace D05double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.Write("Voer een (double) getal ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("in");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": ");
                    double getal = double.Parse(Console.ReadLine());

                    Console.WriteLine("Dank je voor het (double) getal.");
                } while (true);
            }
            catch (FormatException)
            {
                Console.WriteLine("Einde (wegens geen double getal).");
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }

        }
    }
}
