namespace D02hetmaandieet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je gewicht in kg.");
            int gewicht = int.Parse(Console.ReadLine());
            double maanGewicht = gewicht / 6.0;
            Console.WriteLine($"Op de maan zou je {maanGewicht} kg wegen.");
        }
    }
}
