namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People
    {
        private IEnumerable<Discipline> disciplines;

        public Teacher(string name, IEnumerable<Discipline> disciplines, string details = null)
            : base(name, details)
        {
            this.Disciplines = disciplines;
        }

        public IEnumerable<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
           
            set
            {
                if (value != null)
                {
                    this.disciplines = value;
                }
                else
                {
                       throw new ArgumentException("Disciplines set can not be empty!");
                }
            }
        }

        public override string ToString()
        {
            string stingOfDisciplines = string.Join("\n", this.Disciplines);

            string result = string.Format("Teacher name: {0}\nDisciplines:\n{1}", this.Name, stingOfDisciplines);
            result = result + this.StrigifyDetails();

            return result;
        }
    }
}
