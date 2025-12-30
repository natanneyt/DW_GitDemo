using D17Huisdierenregister.Domein;

namespace D17Huisdierenregister.Persistentie
{
    internal class HuisdierBestandIO
    {
        public List<Huisdier> LeesHuisdieren(string relatiefPad)
        {
            List<Huisdier> huisdieren = new List<Huisdier>();
            List<string> foutenlijst = new List<string>();
            using (StreamReader sr = new StreamReader(relatiefPad))
            {
                int regelnummer = 1;

                while(!sr.EndOfStream)
                {
                    try
                    {
                        string[] regelDelen = sr.ReadLine().Split(";");
                        if (regelDelen.Count() < 4) throw new FormatException("Ongeldig aantal velden.");

                        switch (regelDelen[0])
                        {
                            case "Hond":
                                {
                                    huisdieren.Add(new Hond(regelDelen[1], int.Parse(regelDelen[2]), regelDelen[3]));
                                    break;
                                }
                            case "Kat":
                                {
                                    huisdieren.Add(new Kat(regelDelen[1], int.Parse(regelDelen[2]), bool.Parse(regelDelen[3])));
                                    break;
                                }
                            case "Vogel":
                                {
                                    huisdieren.Add(new Vogel(regelDelen[1], int.Parse(regelDelen[2]), bool.Parse(regelDelen[3])));
                                    break;
                                }
                            default:
                                {
                                    throw new ArgumentException("Dit is geen geldig type.");
                                }
                    }
                        regelnummer++;
                    }
                    catch (FormatException ex)
                    {
                        foutenlijst.Add($"Regel {regelnummer}: {ex.Message}");
                        regelnummer++;
                    }
                    catch (Exception ex)
                    {
                        foutenlijst.Add($"Regel {regelnummer}: onverwachte fout: {ex.Message}");
                        regelnummer++;
                    }
                }

                if (foutenlijst.Count > 0)
                {
                    string map = Path.GetDirectoryName(relatiefPad);
                    if (string.IsNullOrWhiteSpace(map)) map = ".";
                    string foutenlijstPad = Path.Combine(map, "foutenlijst.txt");
                    File.WriteAllLines(foutenlijstPad, foutenlijst);
                }
            }
            return huisdieren;
        }
    }
}
