namespace _01.Customer
{
    using System;

    public class Payment : ICloneable
    {
        private string productName;
        private decimal price;

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public string ProductName
        {
            get 
            {
                return this.productName;
            }

            set 
            {
                if (value != null)
                {
                    this.productName = value;
                }
                else
                {
                    throw new ArgumentException("The product must have a name!");
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("The product must have a positive price!");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} for: {1} cost: {2}", GetType().Name, this.ProductName, this.Price);
        }

        public object Clone() 
        {
            return new Payment(this.ProductName, this.Price);
        }
    }
}
