namespace _01.Shapes
{
    using System;

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius) 
        {
            this.Radius = radius;
        }

        public double Radius 
        {
            get 
            { 
                return this.radius; 
            }

            set 
            {
                if (value > 0)
                {
                    this.radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius can not be empty!");
                }
            } 
        }

        public override double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * this.Radius * 2; 
        }
    }
}
