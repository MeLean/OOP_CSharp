namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class TestSchool
    {
        public static void Main()
        {
            Student boncho = new Student("Boncho", "Boncho is clever!");
            Student moncho = new Student("Moncho", "Boncho is not so clever!");
            Student bidoncho = new Student("Bidoncho");

            Discipline math = new Discipline("Math", 5, new List<Student>() { boncho, moncho }, "Math is very tough!");
            Discipline geography = new Discipline("Geography", 4, new List<Student>() { moncho }, "Geography is very easy!");
            Discipline history = new Discipline("History", 6, new List<Student>() { bidoncho }, "History is very interest!");
            
            Teacher daskalPesho = new Teacher("Daskal Pesho", new Discipline[] { math, geography }, "Daskal Pencho is oldshool teacher!");
            Teacher manol = new Teacher("Manol Karaibrahimov", new List<Discipline>() { history });
       
            SchoolClass classA = new SchoolClass("A", new Teacher[] { daskalPesho, manol });
            SchoolClass classB = new SchoolClass("B", new Teacher[] { manol });
            //// it will triger check for existing name. You shold enter a new name. :)
            SchoolClass classC = new SchoolClass("B", new Teacher[] { daskalPesho });
            Console.WriteLine(classA);
            Console.WriteLine(classB);
            Console.WriteLine(classC);
        }
    }
}
