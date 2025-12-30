namespace D15MuziekSpeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Muziekspeler muziekspeler = new Muziekspeler();

            Lied lied1 = new Lied("LIED1");
            Lied lied2 = new Lied("LIED2");

            muziekspeler.VoegLiedToe(lied1);
            muziekspeler.VoegLiedToe(lied2);

            muziekspeler.SpeelLiedAf(0);
            muziekspeler.SpeelLiedAf(1);
        }
    }
}
