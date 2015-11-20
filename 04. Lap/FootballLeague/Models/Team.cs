using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballLeague.Models
{
    public class Team
    {
        private const int MinimumAllowedYear = 1850;
        private string name;
        private string nickName;
        private DateTime dateFounded;
        private List<Player> players;

        public Team(string name, string nickName, DateTime dateFounded)
        {
            this.Name = name;
            this.NickName = nickName;
            this.DateFounded = dateFounded;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Team name should be at least 5 chars long");
                }

                this.name = value;
            }
        }

        public string NickName
        {
            get { return this.nickName; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Team nickname should be at least 5 chars long");
                }

                this.nickName = value;
            }
        }

        public DateTime DateFounded
        {
            get { return this.dateFounded; }
            set
            {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentException("Date of found cannot be earlier than" + MinimumAllowedYear);
                }

                this.dateFounded = value;
            }
        }

        public IEnumerable<Player> Players
        {
            get { return this.players; }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player alredy exists for that team");
            }

            this.players.Add(player);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName &&
                                    p.LastName == player.LastName);
        }

        public override string ToString()
        {
            string print = "--- " + this.name;           
            return print;
        }
    }
}
