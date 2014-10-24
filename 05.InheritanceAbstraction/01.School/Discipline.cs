namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class Discipline
    {
        private string name;
        private int lectionsCount;
        private IEnumerable<Student> students;
        private string details;

        public Discipline(string name, int lectionCount, IEnumerable<Student> students, string details = null)
        {
            this.Name = name;
            this.LectionCount = lectionCount;
            this.Students = students;
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
                    throw new ArgumentException("Discipline's name can not be empty!");
                }
            }
        }

        public int LectionCount
        {
            get
            {
                return this.lectionsCount;
            }

            set
            {
                if (value > 0)
                {
                    this.lectionsCount = value;
                }
                else
                {
                    throw new ArgumentException("Number of lections must be greater than zero!");
                }
            }
        }

        public IEnumerable<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value != null)
                {
                    this.students = value;
                }
                else
                {
                    throw new ArgumentException("Discipline have no students!");
                }
            }
        }

        public string Details
        {
            get { return this.details; }

            set { this.details = value; }
        }

        public override string ToString()
        {
            string stringOfStudents = string.Join("\n", this.students);
            string result = string.Format(
                "Discipline name: {0}, Numer of lections: {1}\nStudents:\n{2}",
                this.name,
                this.lectionsCount, 
                stringOfStudents);

            if (this.details != null)
            {
                result = result + string.Format("\nDetails of {0}: {1}", this.Name, this.details);
            }

            return result;
        }
    }
}
