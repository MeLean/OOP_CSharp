namespace _04.CompanyHierarchy
{
    using System;

    public class Sale : Task
    {
        private uint price;

        public Sale(string productName, DateTime sellDate, uint price)
            : base(productName, sellDate)
        {
            this.Price = price;
        }

        public uint Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(
                " sell date: {0:dd-MMM-yyyy} price: {1:C}",
                this.Date, 
                this.Price);
        }
    }
}
