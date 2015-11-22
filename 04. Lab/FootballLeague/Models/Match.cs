using System;

namespace FootballLeague.Models
{
    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }

        public Team HomeTeam { get; set; }

        public Team AwayTeam { get; set; }

        public Score Score { get; set; }

        public int Id { get; set; }

        public Team GetWinner()
        {
            if (this.Draw())
            {
                return null;
            }

            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals
                ? this.HomeTeam
                : this.AwayTeam;
        }

        private bool Draw()
        {
            return this.Score.AwayTeamGoals == this.Score.HomeTeamGoals;
        }

        public override string ToString()
        {
            string print = "";
            print += "Match: " + this.Id + Environment.NewLine;
            print += this.HomeTeam.Name + " " + this.Score.HomeTeamGoals + Environment.NewLine;
            print += this.AwayTeam.Name + " " + this.Score.AwayTeamGoals + Environment.NewLine;
            return print;
        }
    }
}
