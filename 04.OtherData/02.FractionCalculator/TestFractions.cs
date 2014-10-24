namespace _02.FractionCalculator
{
    using System;
    class TestFractions
    {
        public static void Main()
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;
            //I made a little bit optimisation for more practice you will see that 92 / 7 == 368 / 28 == 13.142857.....
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
        }
    }
}
