using System;
using FootballLeague.Models;
using System.Linq;

namespace FootballLeague
{
    public static class LeagueManager
    {
        public static void  HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam":
                    Team team = new Team(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    League.AddTeam(team);
                    break;
                case "AddMatch":
                    string homeTeamName = inputArgs[2];
                    Team homeTeam = League.Teams.First(t => t.Name == homeTeamName);
                    string awayTeamName = inputArgs[3];
                    Team awayTeam = League.Teams.First(t => t.Name == awayTeamName);
                    League.AddMatch(new Match(homeTeam, awayTeam, new Score(int.Parse(inputArgs[4]), int.Parse(inputArgs[5])), int.Parse(inputArgs[1])));
                    break;
                case "AddPlayerToTeam":
                    string playerTeamName = inputArgs[5];
                    Team playerTeam = League.Teams.First(t => t.Name == playerTeamName);
                    Player player = new Player(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]), decimal.Parse(inputArgs[4]), playerTeamName);
                    playerTeam.AddPlayer(player);
                    break;
                case "ListTeams":
                    Console.WriteLine();
                    foreach (var t in League.Teams)
                    {
                        Console.WriteLine(t.ToString());
                    }
                    Console.WriteLine();
                    break;
                case "ListMatches":
                    Console.WriteLine();
                    foreach (var match in League.Matches)
                    {
                        Console.WriteLine(match.ToString());
                    }
                    break;
            }
        }
    }
}
