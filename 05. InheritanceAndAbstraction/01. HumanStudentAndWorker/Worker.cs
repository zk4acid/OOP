namespace HumanStudentAndWorker
{
    class Worker : Human
    {
        private int workingDaysOfWeek = 5;
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public double WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (decimal)(workingDaysOfWeek * this.WorkHoursPerDay);
        }
    }
}
