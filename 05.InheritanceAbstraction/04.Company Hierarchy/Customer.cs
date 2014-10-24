namespace _04.CompanyHierarchy
{
    using System;

    public class Customer : People
    {
        private decimal purchasAmout;

        public Customer(string firstName, string lastName, uint id, decimal purchasAmout) 
            : base(firstName, lastName, id)
        {
            this.PurchasAmout = purchasAmout;
        }

        public decimal PurchasAmout
        {
            get
            {
                return this.purchasAmout;
            }

            set
            {
                if (value >= 0)
                {
                    this.purchasAmout = value;
                }
                else
                {
                        throw new ArgumentException("Amount can not be negative!");
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" total purchase amount: {0:C}", this.PurchasAmout);
        }
    }
}
