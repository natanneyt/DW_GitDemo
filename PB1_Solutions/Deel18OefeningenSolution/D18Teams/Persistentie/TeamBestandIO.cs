using D18Teams.Domein;
using System.Runtime.CompilerServices;

namespace D18Teams.Persistentie
{
    internal class TeamBestandIO
    {
        public static List<Team> LeesTeams(string relatiefPad)
        {
            int regelnummer = 2;
            List<string> foutenlijst = new List<string>();

            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            using (StreamReader sr = new StreamReader(relatiefPad))
            {
                sr.ReadLine();

                while(!sr.EndOfStream)
                {
                    // spelerId;naam;positie;team;competitie

                    string regel = sr.ReadLine();
                    string[] regelDelen = regel.Split(";");

                    if (regelDelen.Length != 5)
                    {
                        foutenlijst.Add($"Regel {regelnummer}: Ongeldig aantal delen.");
                    }
                    else
                    {
                        Team team = new Team(regelDelen[3], regelDelen[4]);
                        if (!teams.ContainsKey(team.Naam))
                        {
                            teams.Add(team.Naam, team);
                        }
                       
                        try
                        {
                            teams[team.Naam].Spelers.Add(new Speler(regelDelen[0], regelDelen[1], regelDelen[2]));
                        }
                        catch (Exception ex)
                        {
                            foutenlijst.Add($"Regel {regelnummer}: Er is iets misgelopen ({ex.Message}");
                        }
                    }

                    regelnummer++;
                }
            }

            List<Team> teamsLijst = new List<Team>();
            
            foreach(Team team in teams.Values)
            {
                teamsLijst.Add(team);
            }

            if(foutenlijst.Count > 0)
            {
                string map = Path.GetDirectoryName(relatiefPad);
                if (string.IsNullOrWhiteSpace(map)) map = ".";
                string foutenlijstPad = Path.Combine(map, "foutenlijst.txt");
                File.WriteAllLines(foutenlijstPad, foutenlijst);
            }
            return teamsLijst;
        }
    }
}
