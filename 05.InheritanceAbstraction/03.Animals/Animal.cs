namespace _03.Animals
{
    using System;

    public abstract class Animal
    {
        ////Animal can`t get ISoudMekeable because there are animas whic does not make a souds, like fishes, worms, korals and many more. 
        private string name;
        private byte age;
        private string gender;

        public Animal(string name, byte age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
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
                    throw new ArgumentException("Name can not be enpty!");
                }
            }
        }

        public byte Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                if (value.Equals("male") || value.Equals("female") || value.Equals("none"))
                {
                    this.gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be: \"male\", \"female\" or \"none\"");
                }
            }
        }
    }
}
