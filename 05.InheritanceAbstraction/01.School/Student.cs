namespace _01.School
{
    public class Student : People
    {
        private static uint classNumberCounter = 100000;
        private uint classNumber;

        public Student(string name, string details = null) 
            : base(name, details)
        {
            classNumberCounter++;
            this.classNumber = classNumberCounter;
        }

        public uint ClassNumber
        {
            get
            {
                return this.classNumber;
            }
        }

        public override string ToString()
        {
            string result = string.Format("Student name: {0} Number: {1}", this.Name, this.classNumber);
            result = result + this.StrigifyDetails();

            return result;
        }
    }
}