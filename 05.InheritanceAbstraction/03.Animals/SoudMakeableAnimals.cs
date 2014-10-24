namespace _03.Animals
{
    public abstract class SoudMakeableAnimals : Animal, ISoudMakeable
    {
        public SoudMakeableAnimals(string name, byte age, string gender) : base(name, age, gender)
        {
        }

        public abstract void ProduceSound();
    }
}
