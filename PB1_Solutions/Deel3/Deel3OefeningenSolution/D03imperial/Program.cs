namespace D03imperial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het aantal feet : ");
            string aantalFeetAlsTekst = Console.ReadLine();
            double aantalFeet = double.Parse(aantalFeetAlsTekst);

            Console.Write("Geef het aantal inches : ");
            string aantalInchesAlsTekst = Console.ReadLine();
            double aantalInches = double.Parse(aantalInchesAlsTekst);

            double feetNaarCmFactor = 30.48;
            double aantalFeetInCm = aantalFeet * feetNaarCmFactor;

            double inchesNaarCmFactor = 2.54;
            double aantalInchesInCm = aantalInches * inchesNaarCmFactor;

            double totaalInCm = aantalFeetInCm + aantalInchesInCm;

            Console.WriteLine($"Dat is {totaalInCm}cm.");
        }
    }
}
