namespace _03.Class_Student
{
    using System;
    using System.Collections.Generic;
    
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;

        public Student(
            string firstName,
            string lastName,
            int age,
            int facultyNumber,
            string phone,
            string email,
            IList<int> marks,
            int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value != null)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentNullException("First name can not be empty!");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value != null)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentNullException("Last name can not be empty!");
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 18 && value <= 110)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be a number between 18 and 110!");
                }
            }
        }

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (value >= 100000 && value <= 999999)
                {
                    this.facultyNumber = value;
                }
                else
                {
                    throw new ArgumentException("FacultyNumber must be a number between 100000 and 999999!");
                }
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (value != null)
                {
                    this.phone = value;
                }
                else
                {
                    throw new ArgumentNullException("Phone can not be empty!");
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (value != null)
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentNullException("Email can not be empty!");
                }
            }
        }

        public IList<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                if (value > 0)
                {
                    this.groupNumber = value;
                }
                else
                {
                    throw new ArgumentException("GroupNumber must be a number greater than 0!");
                }
            }
        }

        public override string ToString()
        {
            string strMarks = string.Empty;

            if (this.Marks != null)
            {
               strMarks = "[" + string.Join(",", this.Marks);
            }
            else
            {
                strMarks += "none";
            }

            strMarks += "]";

            string result = string.Format(
                "first name: {0}\nlast name: {1}\nage: {2}\nfaculty number: {3}\nphone: {4}\nemail: {5}\nmarks: {6}\ngroup number: {7}",
                this.firstName,
                this.lastName,
                this.age,
                this.facultyNumber,
                this.phone,
                this.email,
                strMarks,
                this.groupNumber);

                return result;
        }
    }
}
