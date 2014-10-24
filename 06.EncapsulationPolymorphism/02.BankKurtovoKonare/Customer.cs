namespace _02.KurtovoKonareBank
{
    using System;

    public abstract class Customer
    {
        private string customerName;
        
        public Customer(string customerName) 
        {
            this.CustomerName = customerName;
        }
        
        public string CustomerName
        {
            get
            {
                return this.customerName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.customerName = value;
                }
                else
                {
                    throw new ArgumentException("Customer can not be empty!");
                }
            }
        }
        
        public override string ToString()
        {
            return this.CustomerName; 
        }
    }
}
