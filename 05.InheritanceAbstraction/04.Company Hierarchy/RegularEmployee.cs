namespace _04.CompanyHierarchy
{
    using System.Collections.Generic;

    public abstract class RegularEmployee : Employee
    {
        private IEnumerable<Task> tasks;
        public RegularEmployee(string firstName, string lastName, uint id, Department department, uint salary, IEnumerable<Task> tasks) 
            : base(firstName, lastName, id, department, salary)
        {
            this.Tasks = tasks;
        }

        public IEnumerable<Task> Tasks
        {
            get { return this.tasks; }
            set { this.tasks = value; }
        }

        public override string ToString()
        {
            string tasksString = string.Join("\n", tasks);
            return base.ToString() + string.Format(" works at:\n{0}", tasksString);
        }
    }
}
