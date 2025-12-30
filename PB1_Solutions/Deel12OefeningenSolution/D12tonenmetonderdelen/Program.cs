namespace D12tonenmetonderdelen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime vandaag = DateTime.Now;
            Console.WriteLine($"De datum van vandaag is {vandaag.Day}/{vandaag.Month}/{vandaag.Year} en het is nu {vandaag.Hour}u{vandaag.Minute}.");
        }
    }
}
