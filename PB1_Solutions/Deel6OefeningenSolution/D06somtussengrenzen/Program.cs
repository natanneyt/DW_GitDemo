namespace D06somtussengrenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de ondergrens: ");
            int ondergrens = int.Parse(Console.ReadLine());

            Console.Write("Geef de bovengrens: ");
            int bovengrens = int.Parse(Console.ReadLine());
            int som = 0;

            for (int i = ondergrens + 1; i < bovengrens; i++)
                som += i;
            Console.WriteLine(som);
        }
    }
}
