using D18Opleidingen.Domein;

namespace D18Opleidingen.Persistentie
{
    internal class StudentenBestandIO
    {
        public static List<Opleiding> LeesOpleidingen(string relatiefPad)
        {
            Dictionary<string, Opleiding> opleidingen = new Dictionary<string, Opleiding>();
            List<Opleiding> opleidingenLijst = new List<Opleiding>();
            int regelnummer = 1;
            List<string> foutenlijst = new List<string>();

            using (StreamReader sr = new StreamReader(relatiefPad))
            {
                while (!sr.EndOfStream)
                {
                    string regel = sr.ReadLine();
                    string[] regelDelen = regel.Split(";");

                    if (regelDelen.Length != 5)
                    {
                        foutenlijst.Add($"Regel {regelnummer}: Niet genoeg delen.");
                    }
                    else
                    {
                        try
                        {
                            Opleiding opleiding = new Opleiding(regelDelen[3], int.Parse(regelDelen[4]));

                            if (!opleidingen.ContainsValue(opleiding)) opleidingen.Add(opleiding.Naam, opleiding);
                            opleidingen[opleiding.Naam].Studenten.Add(new Student(regelDelen[0], regelDelen[1], int.Parse(regelDelen[2])));
                        }
                        catch (Exception ex)
                        {
                            foutenlijst.Add($"Regel {regelnummer}: Er is iets misgelopen: {ex.Message}");
                        }
                    }
                    regelnummer++;
                }
                if(foutenlijst.Count > 0)
                {
                    string map = Path.GetDirectoryName(relatiefPad);
                    if (string.IsNullOrWhiteSpace(map)) map = ".";
                    string foutenlijstPad = Path.Combine(map, "foutenlijst.txt");
                    File.WriteAllLines(foutenlijstPad, foutenlijst);
                }
            }
            opleidingenLijst = opleidingen.Values.ToList<Opleiding>();
            return opleidingenLijst;
        }
    }
}
