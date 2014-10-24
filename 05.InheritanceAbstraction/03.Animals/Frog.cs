namespace _03.Animals
{
    using System;

    public class Frog : SoudMakeableAnimals
    {
        public Frog(string name, byte age, string gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(string.Format(
                "The frog {0}: Ribbit, Ribbit, Qwak.",
                this.Name));
        }
    }
}
