namespace _03.Animals
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, byte age)
            : base(name, age, "female")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(string.Format(
                "The kitten {0}: le miuau, le murrr, le miual.",
                this.Name));
        }
    }
}
