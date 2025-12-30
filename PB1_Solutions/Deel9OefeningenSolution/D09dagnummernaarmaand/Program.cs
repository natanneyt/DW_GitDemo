namespace D09dagnummernaarmaand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aantalDagen = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] maandNamen = { "Januari", "Februari", "Maart", "April", "Mei", "Juni", "Juli", "Augustus", "September", "Oktober", "November", "December" };
            string maand = "onbepaald";
            int gepasseerdeDagen = 0;

            try
            {
                Console.Write("Geef het dagnummer: ");
                int dagnummer = int.Parse(Console.ReadLine());

                for (int i = 0; i < aantalDagen.Length; i++)
                {
                    int einddag = aantalDagen[i];

                    for (int k = 0; k < i; k++)
                    {
                        einddag += aantalDagen[k];
                    }

                    if (i == 0 && dagnummer <= einddag)
                    {
                        maand = maandNamen[i];
                        break;
                    }
                    else if (i > 0 && dagnummer <= einddag)
                    {
                        maand = maandNamen[i];
                        break;
                    }

                    gepasseerdeDagen += einddag;
                }
                Console.WriteLine($"De maand is {maand}.");
            }
            catch
            { 
            
            }
        }
    }
}
