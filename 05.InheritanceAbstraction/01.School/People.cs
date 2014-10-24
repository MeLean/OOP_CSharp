namespace _01.School
{
    using System;

    public abstract class People
    {
        private string name;
        private string details;
        
        public People(string name, string details = null)
        {
            this.Name = name;
            this.Details = details;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name can not be empty!");
                }
            }
        }

        public string Details
        {
            get { return this.details; }

            set { this.details = value; }
        }

        public string StrigifyDetails()
        {
            if (this.Details != null)
            {
                return string.Format("\nDetails of {0}: {1}", this.Name, this.Details);
            }
            else
            {
                return null;
            }
        }
    }
}
