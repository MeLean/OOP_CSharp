namespace _03.Animals
{
    using System;

    public class Dog : SoudMakeableAnimals
    {
        public Dog(string name, byte age, string gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(string.Format(
                "The dog {0}: Bark, bark, ouuuuuuuu.",
                this.Name));
        }
    }
}
