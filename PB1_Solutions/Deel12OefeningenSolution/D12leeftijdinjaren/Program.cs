namespace D12leeftijdinjaren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Geef uw geboortedatum (dd/mm/jjjj): ");
                DateTime geboortedatum = DateTime.Parse(Console.ReadLine());
                DateTime vandaag = DateTime.Now;
                int verschil = vandaag.Year - geboortedatum.Year;

                if (vandaag.DayOfYear < geboortedatum.DayOfYear) verschil--;
                Console.WriteLine($"Vandaag is {vandaag.ToString("dd/MM/yyyy")}, dus u bent {verschil} jaar oud.");
            }
            catch
            {
                Console.WriteLine("Dit is geen geldige datum.");
            }
        }
    }
}
