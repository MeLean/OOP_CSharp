namespace _01.InterestCalculator
{
    using System;

    public class InterestCalculatorTest
    {
        public static void Main()
        {
            InterestCalculator compount = new InterestCalculator(500m, 5.6m, 10, GetCompoundInterest);
            Console.WriteLine(compount);

            Console.WriteLine();

            InterestCalculator simple = new InterestCalculator(2500m, 7.2m, 15, GetSimpleInterest);
            Console.WriteLine(simple);
        }

        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            decimal profit = 0m;
            profit = sum * (1 + ((interest / 100) * years));

            return profit;
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            int timesPerYear = 12;
            decimal profit = 0m;

            profit = sum * Convert.ToDecimal(
                Math.Pow(1 + Convert.ToDouble(interest / 100 / timesPerYear), years * timesPerYear));

            return profit;
        }
    }
}