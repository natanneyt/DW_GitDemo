namespace D12verjaardagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] maanden = new int[12];
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.Write("Geef een geboortedatum: ");
                    string invoer = Console.ReadLine();
                    maanden[DateTime.Parse(invoer).Month - 1]++;
                }
                catch
                {
                    Console.WriteLine("Dit is geen geldige datum.");
                    i--;
                }
            }
            int teller = 1;
            foreach(int maand in maanden)
            {
                if (maand == 1) Console.WriteLine($"Op maand {teller} is er {maand} verjaardag.");
                if (maand > 1) Console.WriteLine($"Op maand {teller} zijn er {maand} verjaardagen.");
                        teller++;
            }
        }
    }
}
