namespace _04.CompanyHierarchy
{
    using System;

    public class Project : Task
    {
        private string details;
        private ProjectState state;
        
        public Project(string projectName, DateTime startDate, string details, ProjectState state)
            : base(projectName, startDate)
        {
            this.Details = details;
            this.State = state;
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.details = value;
                }
            }
        }

        public ProjectState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public void CloseProject()
        {
            this.State = ProjectState.Closed;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(
                " started at {0:dd-MMM-yyyy}\nDetails: {1}\nState: {2}",
                this.Date, 
                this.Details,
                this.State);
        }
    }
}
