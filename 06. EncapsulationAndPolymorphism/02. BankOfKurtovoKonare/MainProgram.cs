using System;
using BankOfKurtovoKonare.Accounts;

namespace BankOfKurtovoKonare
{
    class MainProgram
    {
        static void Main()
        {
            DepositAccount depositAccount = new DepositAccount(new Customer("Pesho", "individual"), 1200m, 10m);
            DepositAccount companyDepositAccount = new DepositAccount(new Customer("Goshos", "company"), 160000m, 8m);
            LoanAccount loanAccount = new LoanAccount(new Customer("Gosho", "individual"), 8000m, 12m);
            MortgageAccount morgageAccount = new MortgageAccount(new Customer("Peshovi", "company"), 12000m, 16m);

            Console.WriteLine("Deposit balanse: " + depositAccount.Balance);
            depositAccount.Deposit(1000);
            Console.WriteLine("After deposit 1000: " + depositAccount.Balance);
            depositAccount.Withdraw(1200);
            Console.WriteLine("After withdraw 1200: " + depositAccount.Balance);
            Console.WriteLine();

            Console.WriteLine("Loan balanse: " + loanAccount.Balance);
            loanAccount.Deposit(1000);
            Console.WriteLine("After deposit 1000: " + loanAccount.Balance);
            Console.WriteLine();

            Console.WriteLine("Morgage balanse: " + morgageAccount.Balance);
            morgageAccount.Deposit(1000);
            Console.WriteLine("After deposit 1000: " + morgageAccount.Balance);
            Console.WriteLine();

            Console.WriteLine("Diderent interest calculations: ");
            Console.WriteLine(depositAccount.CalculateInterest(5));
            Console.WriteLine(depositAccount.CalculateInterest(5));
            Console.WriteLine(loanAccount.CalculateInterest(3));
            Console.WriteLine(loanAccount.CalculateInterest(4));
            Console.WriteLine(morgageAccount.CalculateInterest(6));
            Console.WriteLine(morgageAccount.CalculateInterest(7));
            Console.WriteLine(companyDepositAccount.CalculateInterest(12));
            Console.WriteLine(companyDepositAccount.CalculateInterest(13));
        }
    }
}
