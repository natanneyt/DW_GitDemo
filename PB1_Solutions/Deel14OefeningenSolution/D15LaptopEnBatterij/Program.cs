namespace D15LaptopEnBatterij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Batterij batterij = new Batterij(72);
            Laptop laptop = new Laptop(batterij);
            Console.WriteLine(laptop.GeefLaadniveau());
        }
    }
}
