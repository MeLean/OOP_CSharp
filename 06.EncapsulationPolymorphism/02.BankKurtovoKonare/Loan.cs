namespace _02.KurtovoKonareBank
{
    using System;

    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate) 
        {
        }

        public override decimal CalculateInterestInMonths(int months)
        {
            decimal result = this.Balance;
            int bonusMonths = 0;

            if (this.Customer.GetType().Name.Equals("Individual"))
            {
                bonusMonths = 3;
            }
            else if (this.Customer.GetType().Name.Equals("Company"))
	        {
                bonusMonths = 2;
	        }
            else
            {
                throw new ApplicationException(
                    "I do not know how to calcolate interest of customer type" + this.Customer.GetType());
            }

            if (months > bonusMonths)
            {
                result = base.CalculateInterestInMonths(months - bonusMonths);
            }

            return result;
        }
    }
}
