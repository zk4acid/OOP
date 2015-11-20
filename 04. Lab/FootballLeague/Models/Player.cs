using System;

namespace FootballLeague.Models
{
    public class Player
    {
        private const int MinimumAllowedYear = 1980;
        private string firstName;
        private string lastName;
        private DateTime dayOfBirth;
        private decimal salary;
        private string team;

        public Player(string firstName, string lastName, DateTime dayOfBirth, decimal salary, string team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DayOfBirth = dayOfBirth;
            this.Salary = salary;
            this.Team = team;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("First name should be at least 3 chars long");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Last name should be at least 3 chars long");
                }

                this.lastName = value;
            }
        }

        public DateTime DayOfBirth
        {
            get { return this.dayOfBirth; }
            set
            {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentException("Date of birth cannot be earlier than" + MinimumAllowedYear);
                }

                this.dayOfBirth = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary connot be negative");
                }

                this.salary = value;
            }
        }

        public string Team { get; set; }
    }
}
