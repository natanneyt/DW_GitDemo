namespace D05aantal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vorigeGetal = 0;
            int getal = 0;
            int aantalGetallen = -2;
            try
            {
                do
                {
                    Console.Write("Getal: ");
                    getal = int.Parse(Console.ReadLine());
                    aantalGetallen++;
                    if(getal == vorigeGetal)
                    {
                        Console.WriteLine($"Het aantal getallen (zonder de laatste twee) was {aantalGetallen}.");
                        break;
                    }
                    else
                    {
                        vorigeGetal = getal;
                    }
                } while (true);
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
