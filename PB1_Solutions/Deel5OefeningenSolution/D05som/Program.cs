namespace D05som
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int som = 0;

            try
            {
                do
                {
                    Console.Write("Geef een getal in: ");
                    int getal = int.Parse(Console.ReadLine());
                    if (getal != -1) som += getal;
                    else
                    {
                        Console.WriteLine($"De som van de gegeven getallen is {som}.");
                        break;
                    }
                } while (true);
            }
            catch
            {
                Console.WriteLine("Dit was geen geldig getal");
            }
        }
    }
}
