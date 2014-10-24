namespace _04.CompanyHierarchy
{
    using System.Collections.Generic;

    class SalesEmployee : RegularEmployee
    {
        public SalesEmployee(string firstName, string lastName, uint id, Department department, uint salary, IEnumerable<Sale> sales)
            :base(firstName, lastName, id, department, salary, sales)
        {
        }
    }
}
