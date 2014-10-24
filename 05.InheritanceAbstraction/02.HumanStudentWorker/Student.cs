using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.HumanStudentWorker
{
    public class Student : Human
    {
        private const string Pattern = @"\d\w";
        private string facultyNumber;
        

        public Student(string firstName, string lastName, string facultyNumber) 
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                Match match = Regex.Match(value, Pattern);

                if (match.Success && value.Length >= 3 && value.Length <= 5)
                {
                    this.facultyNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid facultyNumber!\nIt must conteins minimum tree and maximum five letters or words.");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Student: {0} {1} whit faculty number: {2}", this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}
