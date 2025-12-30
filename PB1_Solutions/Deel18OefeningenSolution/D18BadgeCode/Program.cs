using D18Badgecode.Domein;

namespace D18BadgeCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Deelnemer> deelnemers = new List<Deelnemer>();
            deelnemers.Add(new Deelnemer("naam1", "badgecode1"));
            deelnemers.Add(new Deelnemer("naam2", "badgecode2"));
            deelnemers.Add(new Deelnemer("naam3", "badgecode3"));
            deelnemers.Add(new Deelnemer("naam1", "badgecode1"));
            deelnemers.Add(new Deelnemer("naam4", "badgecode4"));
            HashSet<Deelnemer> deelnemersHashed = new HashSet<Deelnemer>(deelnemers);
            Dictionary<string, string> deelnemersDictionary = new Dictionary<string, string>();

            foreach (Deelnemer deelnemer in deelnemersHashed)
            {
                deelnemersDictionary.Add(deelnemer.Badgecode,deelnemer.Naam);
            }

            foreach(string badgecode in deelnemersDictionary.Keys)
            {
                deelnemersDictionary.TryGetValue(badgecode, out string naam);
                Console.WriteLine($"{badgecode}: {naam}");
            }

            string gezochteNaam = "naam3";
            foreach(string badgecode in deelnemersDictionary.Keys)
            {
                deelnemersDictionary.TryGetValue(badgecode, out string naam);
                if (naam == gezochteNaam) Console.WriteLine($"{gezochteNaam} komt voor in de lijst.");
            }

        }
    }
}
