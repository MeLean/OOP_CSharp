namespace _04.CompanyHierarchy
{
    using System.Collections.Generic;

    public class Manager : Employee
    {
        private IEnumerable<Employee> employees;

        public Manager(string firstName, string lastName, uint id, Department department, uint salary, IEnumerable<Employee> employees)
            : base(firstName, lastName, id, department, salary)
        {
            this.Employees = employees;
        }

        public IEnumerable<Employee> Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }

        public override string ToString()
        {
            string employeesString = string.Join("\n", this.Employees);
            return base.ToString() + string.Format("\nIn {0}'s team are:\n{1}\n", this.FirstName, employeesString);
        }
    }
}
