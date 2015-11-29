namespace BankOfKurtovoKonare.Accounts
{
    public abstract class Account
    {
        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public abstract decimal CalculateInterest(int months);
    }
}
