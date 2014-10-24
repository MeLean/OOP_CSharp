namespace _01.Shapes
{
    using System;

    public abstract class BasicShape : Shape
    {
        private double siteA;
        private double siteB;
        private double siteC;

        public BasicShape(double siteA, double siteB)
        {
            this.SiteA = siteA;
            this.SiteB = siteB;
        }

        public BasicShape(double siteA, double siteB, double siteC)
        {
            this.SiteA = siteA;
            this.SiteB = siteB;
            this.SiteC = siteC;
        }
        
        public double SiteA
        {
            get 
            { 
                return this.siteA; 
            }
            
            set 
            {
                if (value > 0)
                {
                    this.siteA = value;
                }
                else
                {
                    throw new ArgumentException("Height must be greater than 0!");
                }
            }
        }

        public double SiteB
        {
            get 
            { 
                return this.siteB;
            }

            set 
            {
                if (value > 0)
                {
                    this.siteB = value;
                }
                else
                {
                    throw new ArgumentException("Height must be greater than 0!");
                }
            }
        }

        public double SiteC
        {
            get 
            { 
                return this.siteC;
            }

            set
            {
                if (value > 0)
                {
                    this.siteC = value;
                }
                else
                {
                    throw new ArgumentException("Height must be greater than 0!");
                }
            }
        }
    }
}
