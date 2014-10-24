namespace _03.Animals
{
    using System;

    public class Cat : SoudMakeableAnimals
    {
        public Cat(string name, byte age, string gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(string.Format(
                "The cat {0}: Miau, Miau, h-hh-hhh.", 
                this.Name));
        }
    }
}
