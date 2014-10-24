namespace _04.CompanyHierarchy
{
    using System;

    public class People
    {
        private string firstName;
        private string lastName;
        private uint id; 

        public People(string firstName, string lastName, uint id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
        }
        
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name can not be empty!");
                }
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
                if (!string.IsNullOrEmpty(value))
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name can not be empty!");
                }
            }
        }

        public uint ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", GetType().Name, this.FirstName, this.LastName);
        }
    }
}
