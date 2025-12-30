namespace D05grootstegetalenaantal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int huidigeGrootste = 0;
            int aantal = 1;

            try
            {
                do
                {
                    Console.Write("Geef een getal in: ");
                    int getal = int.Parse(Console.ReadLine());
                    if (getal != -1)
                    {
                        if (huidigeGrootste < getal)
                        {
                            huidigeGrootste = getal;
                            aantal = 1;
                        }
                        else if (huidigeGrootste == getal) aantal++;
                    }
                    else
                    {
                        Console.WriteLine($"Het grootste getal onder de gegeven getallen is {huidigeGrootste}. Deze kwam {aantal} keer voor.");
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
