namespace D15srt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Welk srt-bestand wil je aanpassen? ");
                string bestand = Console.ReadLine()/*Path.Combine(Environment.CurrentDirectory, Console.ReadLine())*/;
                Console.Write("Milliseconden (positief/negatief) offset: ");
                int offset = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                // Console.WriteLine(bestand);
                // Console.WriteLine(File.ReadAllText(@".\D15srt\Data\" + bestand));

                string[] lijnen = File.ReadAllLines(@".\D15srt\Data\" + bestand);
                File.WriteAllLines(@".\D15srt\Data\" + bestand + ".backup", lijnen);


                string[] eersteCodes = new string[2];
                string[] aangepasteCodes = new string[2];

                foreach (string lijn in lijnen)
                {
                    if (lijn.Contains("-->"))
                    {
                        string eersteTijd = lijn.Substring(0, lijn.IndexOf('-')).Trim();
                        string tweedeTijd = lijn.Substring(lijn.IndexOf('>') + 1).Trim();
                        eersteCodes[0] = eersteTijd;
                        eersteCodes[1] = tweedeTijd;
                        //Console.WriteLine(eersteTijd);
                        //Console.WriteLine(tweedeTijd);
                        string[] eersteTijdCode = eersteTijd.Split(':');
                        DateTime dt1 = new DateTime();

                        dt1 = dt1.AddHours(double.Parse(eersteTijdCode[0]));
                        dt1 = dt1.AddMinutes(double.Parse(eersteTijdCode[1]));
                        dt1 = dt1.AddSeconds(double.Parse(eersteTijdCode[2].Split(',')[0]));
                        dt1 = dt1.AddMilliseconds(double.Parse(eersteTijdCode[2].Split(',')[1]));

                        string[] tweedeTijdCode = tweedeTijd.Split(':');
                        DateTime dt2 = new DateTime();

                        dt2 = dt2.AddHours(double.Parse(tweedeTijdCode[0]));
                        dt2 = dt2.AddMinutes(double.Parse(tweedeTijdCode[1]));
                        dt2 = dt2.AddSeconds(double.Parse(tweedeTijdCode[2].Split(',')[0]));
                        dt2 = dt2.AddMilliseconds(double.Parse(tweedeTijdCode[2].Split(',')[1]));

                        dt1 = dt1.AddMilliseconds(offset);
                        dt2 = dt2.AddMilliseconds(offset);

                        string aangepasteCode1 = $"{dt1.Hour,0:d2}:{dt1.Minute,0:d2}:{dt1.Second,0:d2},{dt1.Millisecond,0:d3}";
                        string aangepasteCode2 = $"{dt2.Hour,0:d2}:{dt2.Minute,0:d2}:{dt2.Second,0:d2},{dt2.Millisecond,0:d3}";


                        lijnen[Array.IndexOf(lijnen, lijn)] = $"{aangepasteCode1} --> {aangepasteCode2}";

                        aangepasteCodes[0] = aangepasteCode1;
                        aangepasteCodes[1] = aangepasteCode2;
                    }
                    else if (lijn.Trim().Length == 0 || lijnen.Length == Array.IndexOf(lijnen, lijn) + 1)
                    {
                        if (lijnen.Length == Array.IndexOf(lijnen, lijn) + 1) Console.WriteLine(lijn);
                        Console.WriteLine($"Start timecode {eersteCodes[0]} aangepast in {aangepasteCodes[0]}");
                        Console.WriteLine($"Einde timecode {eersteCodes[1]} aangepast in {aangepasteCodes[1]}\n");
                    }
                    else Console.WriteLine(lijn);
                }
                File.WriteAllLines(@".\D15srt\Data\" + bestand, lijnen);
                Console.WriteLine($"De aanpassingen zijn doorgevoerd in: {bestand}.");
                Console.WriteLine($"De originele .srt is nog steeds terug te vinden in: {bestand}.backup");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Er treedt een probleem op: {ex.Message} \nProbeer opnieuw...");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Er treedt een probleem op: {ex.Message} \nProbeer opnieuw...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Er treedt een probleem op: {ex.Message} \nProbeer opnieuw...");
            }
        }
    }
}
