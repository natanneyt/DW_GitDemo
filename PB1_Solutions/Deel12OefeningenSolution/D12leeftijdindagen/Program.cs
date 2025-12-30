namespace D12leeftijdindagen
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
                TimeSpan timeSpan = vandaag - geboortedatum;

                double aantalDagen = (double)timeSpan.TotalDays;
                for(int i = geboortedatum.Year; i < vandaag.Year; i++)
                {
                    if (DateTime.IsLeapYear(i)) aantalDagen--;
                }
                double leeftijd = Math.Floor(aantalDagen / 365);

                Console.WriteLine($"Vandaag is {vandaag.ToString("dd/MM/yyyy")}, dus u bent {leeftijd} jaar oud.");
            }
            catch
            {
                Console.WriteLine("Dit is geen geldige datum.");
            }
        }
    }
}
