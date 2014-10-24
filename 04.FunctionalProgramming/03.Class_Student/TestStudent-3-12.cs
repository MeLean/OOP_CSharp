namespace _03.Class_Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestStudent_3_12
    {
        public static void Main()
        {
            // creating a list whit some studets
            List<Student> studentsCollection = CreateStudendColection();

            var studentsByGroup = Problem4StudentsByGroup(studentsCollection);

            PrintSrudents(studentsByGroup);

            WaitToSeeThePage();

            var studentsFirstBeforLastName = Problem5StudentsFirstGreatherLastName(studentsCollection);

            PrintSrudents(studentsFirstBeforLastName);

            WaitToSeeThePage();

            var studentsByAge = Problem6StudentsByAge(studentsCollection);

            PrintSrudents(studentsByAge);

            WaitToSeeThePage();

            Problem7SortStudents(studentsCollection);

            PrintSrudents(studentsCollection);

            WaitToSeeThePage();

            var filteredStudents = Problem8FilterStudentsByEmailDomain(studentsCollection);

            PrintSrudents(filteredStudents);

            WaitToSeeThePage();

            Problem9FilterByPhone(studentsCollection, new string[] { "02", "+3592 ", "+359 2" });

            WaitToSeeThePage();

            Problem10ExcellentStudents(studentsCollection);

            WaitToSeeThePage();

            Problem11WeakStudents(studentsCollection);

            WaitToSeeThePage();

            Console.WriteLine("Problem 12. Students Enrolled in 2014");

            var studentEnrolled =
                from student in studentsCollection
                where student.FacultyNumber.ToString().EndsWith("14")
                select student;

            PrintSrudents(studentEnrolled);
        }

        public static void Problem11WeakStudents(List<Student> studentsCollection)
        {
            Console.WriteLine("Problem 11. Weak Students:");

            var studentWeek =
                from student in studentsCollection
                where student.Marks.Count(x => x == 2) == 2
                select student;

            PrintSrudents(studentWeek);
        }

        public static void Problem10ExcellentStudents(List<Student> studentsCollection)
        {
            Console.WriteLine("Problem 10. Excellent Students:");

            var studentExcellent =
                from student in studentsCollection
                where student.Marks.Contains(6)
                select new { FirstName = student.FirstName, Marks = student.Marks };

            foreach (var student in studentExcellent)
            {
                string strMarks = string.Join(",", student.Marks);
                Console.WriteLine("name: {0}\nmarks: [{1}]", student.FirstName, strMarks);
            }
        }

        public static void Problem9FilterByPhone(List<Student> studentsCollection, string[] phoneStartWhit)
        {
            Console.WriteLine("Problem 9. Filter Students by Phone:");

            for (int i = 0; i < phoneStartWhit.Length; i++)
            {
                var filteredByPhone = studentsCollection.Where(student => student.Phone.StartsWith(phoneStartWhit[i]));

                if (filteredByPhone != null)
                {
                    PrintSrudents(filteredByPhone);
                }
            }
        }

        public static IEnumerable<Student> Problem8FilterStudentsByEmailDomain(List<Student> studentsCollection)
        {
            Console.WriteLine("Problem 8. Filter Students by Email Domain");

            var filteredStudents = studentsCollection.Where(student => student.Email.EndsWith("@abv.bg"));
            return filteredStudents;
        }

        public static void Problem7SortStudents(List<Student> studentsCollection)
        {
            Console.WriteLine("Problem 7. Sort Students\n");
            studentsCollection.Sort((student1, student2) =>
                student1.FirstName.CompareTo(student2.FirstName));
        }

        public static IOrderedEnumerable<Student> Problem6StudentsByAge(List<Student> studentsCollection)
        {
            Console.WriteLine("Problem 6. Students by Age:\n");

            var studentsByAge =
                from student in studentsCollection
                where student.Age != 0
                orderby student.Age
                select student;
            return studentsByAge;
        }

        public static IEnumerable<Student> Problem5StudentsFirstGreatherLastName(List<Student> studentsCollection)
        {
            Console.WriteLine("Problem 5. Students by First greather than Last Name:\n");

            var studentsFirstBeforLastName =
                from student in studentsCollection
                where string.Compare(student.FirstName, student.LastName) < 0
                select student;
            return studentsFirstBeforLastName;
        }

        public static IOrderedEnumerable<Student> Problem4StudentsByGroup(List<Student> studentsCollection)
        {
            Console.WriteLine("Problem 4. Students by Group:\n");

            var studentsByGroup =
                from student in studentsCollection
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            return studentsByGroup;
        }

        public static List<Student> CreateStudendColection()
        {
            List<Student> studentsCollection = new List<Student>();

            studentsCollection.Add(new Student(
                "Pesho",
                "Indjov",
                22,
                100014,
                "029823752",
                "peho_picha@abv.bg",
                new List<int> { 5, 2 },
                1));

            studentsCollection.Add(new Student(
                "Gosho",
                "Indjov",
                22,
                200014,
                "029823752",
                "gosho_picha@abv.bg",
                new List<int> { 2, 6 },
                1));

            studentsCollection.Add(new Student(
                "Pepa",
                "Chipeva",
                26,
                300014,
                "+359 2687001",
                "pepa_chipa@gmail.com",
                new List<int> { 3, 6 },
                1));

            studentsCollection.Add(new Student(
                "Momchil",
                "Popov",
                21,
                400013,
                "+359 02 13 16 23",
                "MomchilPopov@gmail.com",
                new List<int> { 2, 2 },
                2));

            studentsCollection.Add(new Student(
                "Ivan",
                "Katrulev",
                45,
                500013,
                "02 11233",
                "Katrulev@yahoo.com",
                new List<int> { 2, 2 },
                2));

            studentsCollection.Add(new Student(
                "Irina",
                "Stavreva",
                18,
                600013,
                "46 451233",
                "I.Stavreva@stavreva.bg",
                new List<int> { 3, 4 },
                3));

            studentsCollection.Add(new Student(
                "Asan",
                "Kararedjepov",
                28,
                100005,
                "056 344333",
                "asan@abv.bg",
                new List<int> { 6, 6 },
                3));

            return studentsCollection;
        }

        public static void PrintSrudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student + "\n");
            }
        }

        public static void WaitToSeeThePage()
        {
            Console.WriteLine("Press any kay to continue WHIT OTHER PROBLEMS...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
