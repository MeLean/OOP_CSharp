namespace _02.HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestHumanStudentWorker
    {
        public static void Main()
        {
            List<Student> students = InitializeStudents();

            Console.WriteLine("Sorted students by faculty number:");
            students.Sort((student1, student2) => student1.FacultyNumber.CompareTo(student2.FacultyNumber));

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nSorted workers by money per hour:");
            List<Worker> workers = InitializeWorkers();

            var sortedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour());

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("\nSorted humans by first name then by last name:");

            List<Human> humansStudents = new List<Human>(students);
            var humans = humansStudents.Concat(new List<Human>(workers));
            var sortedHumans = humans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);

            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human);
            }
        }

        public static List<Student> InitializeStudents()
        {
            return new List<Student>()
            {
                new Student("Pesho", "Goshev", "A1002"),
                new Student("Angel", "Spiridonov", "A1003"),
                new Student("Moncho", "Bijev", "A1004"),
                new Student("Radosvet", "Buzev", "A1005"),
                new Student("Pesho", "Ivanov", "A1006"),
                new Student("Kurneliq", "Stoqnova", "A1007"),
                new Student("Gosho", "Goshev", "A1008"),
                new Student("Stilqna", "Petrova", "A1009"),
                new Student("Hasan", "Ramzis", "A1010"),
                new Student("Pasha", "Mehmed", "A1001")
            };
        }

        private static List<Worker> InitializeWorkers()
        {
            return new List<Worker>()
            {
                new Worker("Ginka", "Gosheva", 500, 8),
                new Worker("Stoqnka", "Gosheva", 1200, 12),
                new Worker("Pesho", "Gadjev", 220, 4),
                new Worker("Mehmed", "Deli", 400, 7),
                new Worker("Mimiun", "Dishliev", 200, 10),
                new Worker("Ana-Mariq", "Iztreshtqlkova", 600, 8),
                new Worker("Gospodin", "Ivanov", 400, 8),
                new Worker("Kubrat", "Pulev", 1000, 1),
                new Worker("Denica", "Vateva", 600, 7),
                new Worker("Ginka", "Stoqnova", 400, 2)
            };
        }
    }
}