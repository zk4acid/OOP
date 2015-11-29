using System;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Accounts
{
    class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= 3)
            {
                return 0;
            }

            months -= 3;
            return this.Balance * (1 + this.InterestRate * months);
        }

        public void Deposit(decimal deposit)
        {
            this.Balance += deposit;
        }
    }
}
