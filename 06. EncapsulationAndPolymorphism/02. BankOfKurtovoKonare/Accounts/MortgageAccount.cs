using System;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Accounts
{
    class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0;
            if (this.Customer.Type == "company")
            {
                if (months <= 12)
                {
                    return (this.Balance * (1 + this.InterestRate * months)) / 2;
                }

                interest += (this.Balance * (1 + this.InterestRate * 12)) / 2;
                interest += this.Balance * (1 + this.InterestRate * (months - 12));
            }
            if (this.Customer.Type == "individual")
            {
                if (months <= 6)
                {
                    return (this.Balance * (1 + this.InterestRate * months)) / 2;
                }

                interest += (this.Balance * (1 + this.InterestRate * 6)) / 2;
                interest += this.Balance * (1 + this.InterestRate * (months - 6));
            }

            return interest;
        }

        public void Deposit(decimal deposit)
        {
            this.Balance += deposit;
        }
    }
}
