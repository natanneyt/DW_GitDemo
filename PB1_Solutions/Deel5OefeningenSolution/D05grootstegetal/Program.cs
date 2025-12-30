namespace D05grootstegetal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int huidigeGrootste = 0;

            try
            {
                do
                {
                    Console.Write("Geef een getal in: ");
                    int getal = int.Parse(Console.ReadLine());
                    if (getal != -1)
                    {
                        if (huidigeGrootste < getal) huidigeGrootste = getal;
                    }
                    else
                    {
                        Console.WriteLine($"Het grootste getal onder de gegeven getallen is {huidigeGrootste}.");
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
