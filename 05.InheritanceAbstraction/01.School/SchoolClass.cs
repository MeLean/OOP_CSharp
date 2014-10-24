namespace _01.School
{
    using System;
    using System.Collections.Generic;

    internal class SchoolClass
    {
        private static List<string> uniqueClassNames = new List<string>();
        private string name;
        private IEnumerable<Teacher> teachers;

        public SchoolClass(string name, IEnumerable<Teacher> teachers)
        {
            this.Teachers = teachers;
            this.Name = name;
        }

        public IEnumerable<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }

            set
            {
                if (value != null)
                {
                    this.teachers = value;
                }
                else
                {
                    throw new ArgumentException("Class must have teachers!");
                }
            }
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
                    if (!uniqueClassNames.Contains(value))
                    {   
                        uniqueClassNames.Add(value);
                        this.name = value;
                    }
                    else
                    {
                        Console.WriteLine(string.Format("The name: \"{0}\" already exist.", value));
                        Console.WriteLine(string.Format("The existing class`s names are: {0}", string.Join(", ", uniqueClassNames)));
                        Console.WriteLine("\nPlease, enter new name for the class or just press \"Enter\"");
                        value = Console.ReadLine();
                        this.Name = value;
                    }
                }
                else
                {
                    throw new ArgumentException("The Class name can not be empty!");
                }
            }
        }

        public override string ToString()
        {
            string stringOfTeachers = string.Join("\n", this.teachers);
            string result = string.Format("Class name: {0}, in class:\n{1}\n", this.name, stringOfTeachers);

            return result;
        }
    }
}
