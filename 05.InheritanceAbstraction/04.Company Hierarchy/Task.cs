namespace _04.CompanyHierarchy
{
    using System;

    public abstract class Task
    {
        private string name;
        private DateTime date;

        public Task(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;
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
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} \"{1}\"", this.GetType().Name, this.name);
        }
    }
}
