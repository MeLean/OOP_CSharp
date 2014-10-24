namespace _01.InterestCalculator
{
    using System;

    public class InterestCalculator
    {
        private decimal sum;
        private decimal interest;
        private int years;
        private decimal result;

        public InterestCalculator(decimal sum, decimal interest, int years, CalculateInterest deleg)
        {
            if (sum > 0)
            {
                this.sum = sum;
            }
            else
            {
                throw new ArgumentException("The sum must be positive number!");
            }

            if (interest > 0)
            {
                this.interest = interest;
            }
            else
            {
                throw new ArgumentException("The interest must be positive number!");
            }

            if (years >= 1 && years <= 50)
            {
                this.years = years;
            }
            else
            {
                throw new ArgumentException("The years must be in interval 1 and 50!");
            }

            if (deleg != null)
            {
                this.result = deleg(sum, interest, years);
            }
            else
            {
                throw new ArgumentNullException("The delegat can not be null!");
            }
        }

        public delegate decimal CalculateInterest(decimal sum, decimal interest, int years);

        public override string ToString()
        {
            return string.Format(
                "Money: {0:F2} | Interest: {1:F4} | Years: {2} | Result: {3:F4}",
                this.sum,
                this.interest, 
                this.years, 
                this.result);
        }
    }
}