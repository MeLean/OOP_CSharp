namespace _02.KurtovoKonareBank
{
    using System;

    class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate) 
        {
        }

        public override decimal CalculateInterestInMonths(int months)
        {
            if (months > 0)
            {
                decimal result = this.Balance;
                int bonusMonths = 0;

                if (this.Customer.GetType().Name.Equals("Individual"))
                {
                    bonusMonths = 6;

                    if (months > bonusMonths)
                    {
                        result = base.CalculateInterestInMonths(months - bonusMonths);
                    }
                }
                else if (this.Customer.GetType().Name.Equals("Company"))
                {
                    bonusMonths = 12;
                    decimal lessInterest = 0.5m;

                    if (months > bonusMonths)
                    {
                        result = this.Balance * (1 + (this.InterestRate / 100 * lessInterest * bonusMonths)) +
                            base.CalculateInterestInMonths(months - bonusMonths);
                    }
                    else
                    {
                        result = this.Balance * (1 + (this.InterestRate / 100 * lessInterest * months));
                    }
                }
                else
                {
                    throw new ApplicationException(
                        "I do not know how to calcolate interest of customer type" + this.Customer.GetType());
                }

                return result;
            }
            else
            {
                throw new ArgumentException("Months must be greather than zero!");
            }
        }
    }
}
