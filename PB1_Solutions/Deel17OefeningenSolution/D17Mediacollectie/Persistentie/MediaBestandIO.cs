using D17Mediacollectie.Domein;

namespace D17Mediacollectie.Persistentie
{
    internal class MediaBestandIO
    {
        public List<MediaItem> LeesMedia(string relatiefPad)
        {
            using (StreamReader sr = new StreamReader(relatiefPad))
            {
                List<MediaItem> media = new List<MediaItem>();
                List<string> foutenlijst = new List<string>();
                int regelnummer = 1;

                while (!sr.EndOfStream)
                {
                    try
                    {
                        string regel = sr.ReadLine();
                        string[] regelDelen = regel.Split(";");

                        switch(regelDelen[0])
                        {
                            case "Lied":
                                {
                                    media.Add(new Lied(regelDelen[1], int.Parse(regelDelen[2]), regelDelen[3]));
                                    break;
                                }
                            case "Instrumentaal":
                                {
                                    media.Add(new Instrumentaal(regelDelen[1], int.Parse(regelDelen[2]), regelDelen[3]));
                                    break;
                                }
                            case "Podcast":
                                {
                                    media.Add(new Podcast(regelDelen[1], int.Parse(regelDelen[2]), regelDelen[3]));
                                    break;
                                }
                            default: throw new FormatException("Type niet gevonden.");
                        }

                        regelnummer++;
                    }
                    catch (FormatException ex)
                    {
                        foutenlijst.Add($"Regel {regelnummer}: onverwachte fout ({ex.Message})");
                        regelnummer++;
                    }
                    catch (Exception ex)
                    {
                        foutenlijst.Add($"Regel {regelnummer}: {ex.Message}");
                        regelnummer++;
                    }
                }

                if(foutenlijst.Count > 0)
                {
                    string map = Path.GetDirectoryName(relatiefPad);
                    if (string.IsNullOrWhiteSpace(map)) map = ".";
                    string foutenlijstPad = Path.Combine(map, "foutenlijst.txt");
                    File.WriteAllLines(foutenlijstPad, foutenlijst);
                }

                return media;
            }
        }
    }
}
