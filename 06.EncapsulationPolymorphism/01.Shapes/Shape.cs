namespace _01.Shapes
{
    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public override string ToString()
        {
            return string.Format(
                "{0:#.##} whit perimeter: {1:#.##} and area: {2:#.##}",
                this.GetType().Name,
                this.CalculatePerimeter(),
                this.CalculateArea());
        }
    }
}
