using D17Bibliotheekcatalogus.Domein;

namespace D17Bibliotheekcatalogus.Persistentie
{
    internal class PublicatieBestandIO
    {
        public List<Publicatie> LeesPublicaties(string relatiefPad)
        {
            List<Publicatie> publicaties = new List<Publicatie>();
            List<string> foutenlijst = new List<string>();

            using (StreamReader sr = new StreamReader(relatiefPad))
            {
                int regelnummer = 1;
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string regel = sr.ReadLine();
                        string[] regelDelen = regel.Split(";");

                        if (regelDelen.Count() != 4) throw new FormatException("Ongeldig aantal velden");

                        switch(regelDelen[0])
                        {
                            case "Boek":
                            {
                                    publicaties.Add(new Boek(regelDelen[1], int.Parse(regelDelen[2]), regelDelen[3]));
                                break;
                            }

                            case "Tijdschrift":
                            {
                                    publicaties.Add(new Tijdschrift(regelDelen[1], int.Parse(regelDelen[2]), regelDelen[3]));
                                    break;
                            }

                            case "Strip":
                            {
                                    publicaties.Add(new Strip(regelDelen[1], int.Parse(regelDelen[2]), regelDelen[3]));
                                    break;
                            }

                            default:
                            {
                                break;
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
                        foutenlijst.Add($"Regel {regelnummer}: onverwachte fout ({ex.Message})");
                        regelnummer++;
                    }
                }
            }

            if(foutenlijst.Count > 0)
            {
                string map = Path.GetDirectoryName(relatiefPad);
                if (string.IsNullOrWhiteSpace(map)) map = ".";
                string padFoutenlijst = Path.Combine(map, "foutenlijst.txt");
                File.WriteAllLines(padFoutenlijst, foutenlijst);
            }

            return publicaties;
        }
    }
}
