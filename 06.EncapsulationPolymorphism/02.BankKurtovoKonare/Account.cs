namespace _02.KurtovoKonareBank
{
    using System;

    public abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate) 
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value > 0)
                {
                    this.interestRate = value;
                }
                else
                {
                    throw new ArgumentException("Interest must be positive!");
                }
            }
        }

        public Customer Customer 
        {
            get
            {
                return this.customer;
            }

            set
            {
                if (value != null)
                {
                    this.customer = value;
                }
                else
                {
                    throw new ArgumentException("Customer is required!");
                }
            }
        }

        public virtual decimal CalculateInterestInMonths(int months) 
        {
            return this.Balance * (1 + (this.InterestRate / 100 * months));
        }

        public virtual void MakeDeposit(decimal deposit)
        {
            if (this.Balance >= deposit)
            {
                this.Balance -= deposit;
            }
            else
            {
                throw new ApplicationException("You are trying to deposit more that your dept!" + 
                    "\n If You want you could make a Deposit!");
            }            
        }

        public override string ToString()
        {
            return string.Format(
                "{0} {1} has:\nbalance: {2:C2}\n{3}`s interest rate: {4:F2}%",
                this.Customer.GetType().Name,
                this.Customer.ToString(),
                this.Balance,
                this.GetType().Name,
                this.InterestRate);                             
        }
    }
}
