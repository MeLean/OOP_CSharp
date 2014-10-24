namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;

    class TestShapes
    {
        public static void Main() 
        {
            List<IShape> shapes = new List<IShape>()
            {
                new Rectangle(5.4, 6),
                new Circle(5.4),
                new Triangle(5.4, 6, 3.5),
                //// The folowing is an invalid triangle:
                // new Triangle(5.4, 6, 0.5),
                new Rectangle(5, 16),
                new Rectangle(3, 6),
                new Circle(6),
                new Triangle(42, 62, 75),
            };
            
            Console.WriteLine("Entered shapes are:");

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
