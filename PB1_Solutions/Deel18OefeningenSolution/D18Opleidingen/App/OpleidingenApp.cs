using D18Opleidingen.Domein;

namespace D18Opleidingen.App
{
    internal class OpleidingenApp
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            string pad = @"./D18Opleidingen/Data/studenten.csv";
            manager.LeesOpleidingen(pad);

            List<Opleiding> opleidingen = manager.GeefOpleidingen();

            Console.WriteLine("Overzicht van opleidingen:");
            foreach(Opleiding opleiding in opleidingen)
            {
                Console.WriteLine(opleiding);
            }
            Console.Write($"\nGeef een opleidingsnaam in om studenten te tonen: ");
            string invoer = Console.ReadLine().Trim().ToLower();

            foreach(Opleiding opleiding in opleidingen)
            {
                if (opleiding.Naam.Trim().ToLower() == invoer) Console.WriteLine($"Studenten in {opleiding.Naam}:" + opleiding.GeefStudentenlijst());
            }

            string foutenlijstPad = @"./D18Opleidingen/Data/foutenlijst.txt";
            if (File.Exists(foutenlijstPad)) Console.WriteLine($"Er zijn fouten gevonden: zie {foutenlijstPad}");
        }
    }
}
