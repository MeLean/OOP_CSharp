namespace _04.CompanyHierarchy
{
    using System.Collections.Generic;

    class Developer : RegularEmployee
    {
        public Developer(string firstName, string lastName, uint id, Department department, uint salary, IEnumerable<Project> projects)
            : base(firstName, lastName, id, department, salary, projects)
        {
        }
    }
}
