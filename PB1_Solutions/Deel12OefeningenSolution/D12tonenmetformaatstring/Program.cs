namespace D12tonenmetformaatstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime vandaag = DateTime.Now;
            string datum = vandaag.ToString("dd/MM/yyyy");
            string uur = vandaag.ToString("HHumm");
            Console.WriteLine($"De datum van vandaag is {datum} en het is nu {uur}.");
        }
    }
}
