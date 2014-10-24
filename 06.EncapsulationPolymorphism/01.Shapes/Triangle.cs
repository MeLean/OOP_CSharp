namespace _01.Shapes
{
    using System;

    public class Triangle : BasicShape
    {
        public Triangle(double siteA, double siteB, double siteC) 
            : base(siteA, siteB, siteC)
        {
            bool isTriangle =
                (siteA + SiteB) > siteC &&
                (siteC + SiteB) > siteA &&
                (siteA + SiteC) > siteB;

            if (!isTriangle)
            {
                throw new ApplicationException(string.Format(
                    "Entered values: {0}, {1} and {2} can not make a triangle!",
                    this.SiteA,
                    this.SiteB,
                    this.SiteC));
            }
        }        

        public override double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;

            return Math.Sqrt(p * (p - this.SiteA) * (p - this.SiteB) * (p - this.SiteC));
        }
        
        public override double CalculatePerimeter()
        {          
            return this.SiteA + this.SiteB + this.SiteC;
        }
    }
}
