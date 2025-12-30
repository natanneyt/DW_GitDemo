namespace D02Volwassen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoe oud ben je?");
            int leeftijd = int.Parse(Console.ReadLine());
            if (leeftijd >= 18)
                Console.WriteLine("Je bent wel volwassen");
            else Console.WriteLine("Je bent niet volwassen..");
        }
    }
}
