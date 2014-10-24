namespace _03.Animals
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, byte age)
            : base(name, age, "male")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(string.Format(
                "The tomcat {0}: le Java, le Apache, miau.",
                this.Name));
        }
    }
}
