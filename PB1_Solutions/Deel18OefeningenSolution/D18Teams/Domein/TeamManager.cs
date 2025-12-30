using D18Teams.Persistentie;

namespace D18Teams.Domein
{
    internal class TeamManager
    {
        public List<Team> Teams { get; set; } = new List<Team>();

        public void LeesTeams(string relatiefPad)
        {
            Teams = TeamBestandIO.LeesTeams(relatiefPad);
        }

        public List<Team> GeefTeams()
        {
            return Teams;
        }
    }
}
