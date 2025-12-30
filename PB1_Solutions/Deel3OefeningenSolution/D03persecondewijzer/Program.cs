namespace D03persecondewijzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het aantal seconden om om te zetten");
            int totaalSeconden = int.Parse(Console.ReadLine());


            int rest = totaalSeconden;
            int uren = totaalSeconden / 3600;
            rest %= 3600;

            int minuten = rest / 60;
            rest %= 60;

            int seconden = rest;
            Console.WriteLine($"{totaalSeconden} kunnen we omzetten naar {uren} uren, {minuten} minuten en {seconden} seconden.");

        }
    }
}
