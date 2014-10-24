namespace _02.KurtovoKonareBank
{
    using System;

    public class Deposit : Account
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate) 
        {
        }

        public override decimal CalculateInterestInMonths(int months)
        {
            decimal result = this.Balance;
            decimal minimumBalnaceToGetProfit = 1000;

            if (this.Balance >= minimumBalnaceToGetProfit)
            {
                result = base.CalculateInterestInMonths(months);  
            }

            return result;
        }

        public void Withdraw(decimal sum) 
        {
            if (this.Balance - sum >= 0)
            {
                this.Balance -= sum;
            }
            else
            {
                throw new ApplicationException("You are trying to withdrow more than you have!");
            }
        }

        public override void MakeDeposit(decimal deposit)
        {
            this.Balance += deposit;
        }
    }
}
