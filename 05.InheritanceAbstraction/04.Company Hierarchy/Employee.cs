namespace _04.CompanyHierarchy
{
    public class Employee : People
    {
        private Department department;
        private uint salary;

        public Employee(string firstName, string lastName, uint id, Department department, uint salary) 
            : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public uint Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" works in {0} gets salary: {1:C}", this.Department, this.Salary);
        }
    }
}
