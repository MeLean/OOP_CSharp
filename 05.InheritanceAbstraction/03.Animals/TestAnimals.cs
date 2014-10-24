namespace _03.Animals
{
    using System.Collections.Generic;

    public class TestAnimals
    {
        public static void Main()
        {
            var animals = new List<SoudMakeableAnimals>()
            {
                new Cat("Maria", 3, "female"),
                new Frog("Kermit", 59, "male"),
                new Kitten("Dresla", 2),
                new Dog("Murdjo", 10, "male"),
                new Tomcat("Thomas", 74)
            };

            animals.ForEach(animal => animal.ProduceSound());
        }
    }
}
