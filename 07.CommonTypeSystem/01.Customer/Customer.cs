namespace _01.Customer
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Threading;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName; 
        private string lastName;
        private string id;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private List<Payment> payments;
        private CustomerType type;

        public Customer(
            string firstName,
            string middleName,
            string lastName, 
            string id, 
            string permanentAddress,
            string mobilePhone,
            string email,
            List<Payment> payments,
            CustomerType type) 
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = payments;
            this.Type = type;
        }

        public string FirstName
        { 
            get
            {
                return this.firstName;
            }

            set 
            {
                if (value != null)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name can not be empty");
                }
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value != null)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name can not be empty");
                }
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                // (?<!.) - there is nothing in front (?!.) - there is nothing after
                Regex regEx = new Regex(@"(?<!.)\d{10}(?!.)");
                bool isValidId = value != null && regEx.IsMatch(value);

                if (isValidId)
                {
                    this.id = value;
                }
                else
                {
                    throw new ArgumentException("Invalid ID!");
                }
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }

            set
            {
                if (value != null)
                {
                    this.permanentAddress = value;
                }
                else
                {
                    throw new ArgumentException("Permanent address name can not be empty!");
                }
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            set
            {
                Regex regEx = new Regex(@"^[0-9 +-]+?");
                bool isValidId = value != null && regEx.IsMatch(value);

                if (isValidId)
                {
                    this.mobilePhone = value;
                }
                else
                {
                    throw new ArgumentException("Invalid mobile phone!");
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                Regex regEx = new Regex(@"[0-9A-Za-z._-]+@[0-9A-Za-z._-]+");
                bool isValidId = value != null && regEx.IsMatch(value);

                if (isValidId)
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Email!");
                }
            }
        }

        public List<Payment> Payments
        {
            get
            {
                return this.payments;
            }

            set
            {
                this.payments = value;
            }
        }

        public CustomerType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }
        
        public static bool operator ==(Customer customerOne, Customer customerTwo)
        {
            return customerOne.Equals(customerTwo);
        }

        public static bool operator !=(Customer customerOne, Customer customerTwo)
        {
            return !customerOne.Equals(customerTwo);
        }
        
        public override string ToString()
        {
            string paymerstToString = string.Join("\n", this.Payments);
            return string.Format(
                "{0} {1} {2}, type: {3}\n{4}",
                this.firstName,
                this.middleName,
                this.LastName,
                this.type.ToString(),
                paymerstToString);
        }
       
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                bool result = true;
                Customer comaredCustomer = obj as Customer;

                if (comaredCustomer == null)
                {
                    result = false;
                }

                if (this.Id != comaredCustomer.Id)
                {
                    result = false;
                }

                return result;
            }
            else
            {
                return false;  
            }
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.Email.GetHashCode();
        }

        public object Clone()
        {
            var paymentListCloning = new List<Payment>();

            foreach (var payment in this.Payments)
            {
                paymentListCloning.Add(payment.Clone() as Payment);
            }
            
            var result = new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Id,
                this.PermanentAddress,
                this.MobilePhone,
                this.Email,
                paymentListCloning,
                this.type);

            return result;
        }

        public int CompareTo(Customer comparedCustomer)
        {
            string thisFullName = string.Format(
                "{0} {1} {2}",
                this.FirstName,
                this.MiddleName,
                this.LastName);

            string comparedFullName = string.Format(
                "{0} {1} {2}",
                comparedCustomer.FirstName,
                comparedCustomer.MiddleName, 
                comparedCustomer.LastName);

            if (thisFullName != comparedFullName)
            {
                return thisFullName.CompareTo(comparedFullName);
            }

            return this.Id.CompareTo(comparedCustomer.Id);
        }
    }
}
