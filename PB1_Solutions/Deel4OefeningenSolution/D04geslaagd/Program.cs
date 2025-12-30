namespace D04geslaagd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je score van deel 1");
            double deel1Score = double.Parse(Console.ReadLine());

            Console.WriteLine("Geef je score van deel 2");
            double deel2Score = double.Parse(Console.ReadLine());

            Console.WriteLine("Geef je score van deel 3");
            double deel3Score = double.Parse(Console.ReadLine());

            double totaalScore = deel1Score + deel2Score + deel3Score;

            double minimumPerOnderdeel = 5;
            double laagsteToegelatenScore = 4;
            double minimumInTotaal = 18;

            if (deel1Score >= minimumPerOnderdeel && deel2Score >= minimumPerOnderdeel && deel3Score >= minimumPerOnderdeel)
            {
                Console.WriteLine("Geslaagd.");
            }
            else if (deel1Score >= laagsteToegelatenScore && deel2Score >= laagsteToegelatenScore && deel3Score >= laagsteToegelatenScore
                && totaalScore >= minimumInTotaal)
            {
                Console.WriteLine("Geslaagd");
            }
            else
            {
                Console.WriteLine("Niet geslaagd.");
            }
        }
    }
}
