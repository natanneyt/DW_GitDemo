namespace D14afstandtussenpunten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punt punt1 = new Punt(4, 6);
            Punt punt2 = new Punt(7, 2);

            Console.WriteLine($"De afstand tussen ({punt1.X},{punt1.Y}) en ({punt2.X},{punt2.Y}) is {punt1.BerekenAfstandTussen(punt2)}");
        }
    }
}
