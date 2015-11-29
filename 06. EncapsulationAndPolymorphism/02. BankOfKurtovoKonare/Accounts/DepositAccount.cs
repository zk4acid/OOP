using System;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Accounts
{
    class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return this.Balance * (1 + this.InterestRate * months);
        }

        public void Deposit(decimal deposit)
        {
            this.Balance += deposit;
        }

        public void Withdraw(decimal withdraw)
        {
            this.Balance -= withdraw;
        }

    }
}
