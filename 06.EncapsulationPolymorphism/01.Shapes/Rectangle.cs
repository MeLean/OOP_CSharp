namespace _01.Shapes
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double siteA, double siteB) 
            : base(siteA, siteB)
        {
        }
        
        public override double CalculateArea() 
        {
            return this.SiteA * this.SiteB;
        }

        public override double CalculatePerimeter()
        {
            return (2 * this.SiteA) + (2 * this.SiteB);
        }
    }
}
