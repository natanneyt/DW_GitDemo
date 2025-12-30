using D18Teams.Domein;

namespace D18Teams.App
{
    internal class TeamApp
    {
        static void Main(string[] args)
        {
            TeamManager manager = new TeamManager();
            manager.LeesTeams(@"./D18Teams/Data/spelers.csv");

            List<Team> teams = manager.GeefTeams();

            Console.WriteLine("Overzicht van teams:");
            foreach(Team team in teams)
            {
                Console.WriteLine(team);
            }

            Console.Write("\nGeef een teamnaam in om spelers te tonen: ");
            string invoer = Console.ReadLine().Trim().ToLower();

            foreach(Team team in teams)
            {
                if(team.Naam.Trim().ToLower() == invoer)
                {
                    Console.WriteLine($"Spelers voor {team.Naam}" + team.GeefSpelerlijst());
                }
            }
        }
    }
}
