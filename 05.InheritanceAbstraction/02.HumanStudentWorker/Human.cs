namespace _02.HumanStudentWorker
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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
    }
}
