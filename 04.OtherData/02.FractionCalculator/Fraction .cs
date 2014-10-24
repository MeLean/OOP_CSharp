namespace _02.FractionCalculator
{
    using System;
    using System.Globalization;
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; } 
            set { this.numerator = value; }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if (value != 0)
                {
                    this.denominator = value;
                }
                else
                {
                    throw new DivideByZeroException("Demominator can not be zero!");
                }
            }
        }

        public static Fraction operator +(Fraction one, Fraction two)
        {
            long newNumerator = 0;
            long newDenumnenator = 0;

            newNumerator = (one.Numerator * two.Denominator) + (one.Denominator * two.Numerator);
            newDenumnenator = one.Denominator * two.Denominator;

            return FractionPriming(new Fraction(newNumerator, newDenumnenator));
        }

        public static Fraction operator -(Fraction one, Fraction two)
        {
            long newNumerator = 0;
            long newDenumnenator = 0;

            newNumerator = (one.Numerator * two.Denominator) - (one.Denominator * two.Numerator);
            newDenumnenator = one.Denominator * two.Denominator;

            return FractionPriming(new Fraction(newNumerator, newDenumnenator));
        }

        public override string ToString()
        {
            string result = ((double)this.Numerator / this.Denominator).ToString();

            return result;
        }

        public static Fraction FractionPriming(Fraction fp)
        {
            long returnNumerator = fp.Numerator;
            long returnDenominator = fp.Denominator;
            long biggerField = Math.Max(fp.Numerator, fp.Denominator);
            double maxDevider = Math.Sqrt(biggerField);
            int counter = 2;
            
            while (counter <= maxDevider)
            {
                if (returnNumerator % counter == 0 && returnDenominator % counter == 0)
                {
                    returnNumerator = returnNumerator / counter;
                    returnDenominator = returnDenominator / counter;
                }
                else
                {
                    counter++;
                }
            }

            return new Fraction(returnNumerator, returnDenominator);
        }
    }
}
