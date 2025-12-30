namespace D05somvanafstop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int som = 0;

                do
                {
                    int getal = 0;
                    string invoer = Console.ReadLine();
                    if (invoer.ToUpper().Trim() == "STOP")
                    {
                        Console.WriteLine("=");
                        Console.WriteLine(som);
                        break;
                    }
                    else if (int.TryParse(invoer, out getal))
                    {
                        som += getal;
                        Console.WriteLine("+");
                        continue;
                    }
                    else
                    {
                        Console.Write("Gelieve een geheel getal ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("in ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("te voeren (of \"STOP\" om te stoppen).");
                        continue;
                    }
                } while (true);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Data);
            }
        }
    }
}
