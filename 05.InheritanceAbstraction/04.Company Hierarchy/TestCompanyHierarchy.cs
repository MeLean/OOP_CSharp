using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy
{
    internal class TestCompanyHierarchy
    {
        public static void Main()
        {
            var developerPesho = MakeDeveloperPesho();
            var salerGosho = MakeSalerGosho();
            var managerTatko = MakeManagerTatko(developerPesho, salerGosho);
            var CcustomerGinka = MakeCustomerGinka();

            List<People> peopleInvolved = new List<People>();
            peopleInvolved.Add(managerTatko);
            peopleInvolved.Add(developerPesho);
            peopleInvolved.Add(salerGosho);
            peopleInvolved.Add(CcustomerGinka);

            foreach (var person in peopleInvolved)
            {
                Console.WriteLine(person);
                Console.WriteLine("----------------------------------------");
            }

        }

        private static Customer MakeCustomerGinka()
        {
            var customerGinka = new Customer(
                "Ginka",
                "Stoqnova",
                12345,
                700
                );

            return customerGinka;
        }

        private static Manager MakeManagerTatko(Developer DeveloperPesho, SalesEmployee SalerGosho)
        {
            var managerTatko = new Manager(
                "Milen",
                "Stoqnov",
                10004,
                Department.Marketing,
                2800,
                new List<Employee>()
                {
                    DeveloperPesho,
                    SalerGosho
                });

            return managerTatko;
        }

        private static SalesEmployee MakeSalerGosho()
        {
            var salerGosho = new SalesEmployee(
                "Gosho",
                "Stoqnov",
                10003,
                Department.Sales,
                900, new List<Sale>()
                {
                    new Sale("Parser Mashine", DateTime.Parse("22.10.2012"), 220),
                    new Sale("Lections", DateTime.Parse("23.10.2012"), 120),
                    new Sale("Utilities", DateTime.Parse("24.10.2012"), 340),
                    new Sale("Programming shoes", DateTime.Parse("24.10.2012"), 20)
                });

            return salerGosho;
        }

        private static Developer MakeDeveloperPesho()
        {
            var developerPesho = new Developer(
                "Pesho",
                "Stoqnov",
                10002,
                Department.Accounting,
                1400, new List<Project>()
                {
                    new Project("AstalaVisataSista", DateTime.Parse("22.10.2012"), "Improves Sister's love.",
                        ProjectState.Open),
                    new Project("Lotus", DateTime.Parse("22.10.2013"), "PC language Lotus programming.",
                        ProjectState.Open)
                });

            return developerPesho;
        }
    }
}
