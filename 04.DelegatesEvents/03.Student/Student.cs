
namespace _03.Student
{
    using System;

    

    public class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value != null)
                {
                    //// to avoid exeption in first change
                    if (this.name != null)
                    {
                        this.OnPropertyChanged(new PropertyChangedEventArgs("Name", this.name, value));                        
                    }

                    this.name = value;
                }
                else
                {

                    throw new NullReferenceException("You shoud enter your name!");
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
                    this.OnPropertyChanged(new PropertyChangedEventArgs("Age", this.age, value));
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("The age must be between 18 and 110!");
                }
            }
        }

        public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }

        }
    }
}
