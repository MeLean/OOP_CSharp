namespace _03.GenericList
{
    using System;

    public class GenericListTest
    {
        public static void Main()
        {
            //// version for task four
            System.Reflection.MemberInfo info = typeof(GenericList<>);
            var attributes = info.GetCustomAttributes(true);

            foreach (var atribute in attributes)
            {
                Console.WriteLine(atribute.ToString());
            }
            
            //// task three
            GenericList<int> intTest = new GenericList<int>();
            int moreThabDefCapacity = 20;

            for (int i = 0; i < moreThabDefCapacity; i++)
            {
                intTest.Add(i);
            }
            
            Console.WriteLine(string.Format("The array members are:\n{0}", intTest));
            Console.WriteLine("capacity = " + intTest.Capacity + " count = " + intTest.Count + "\n");

            Console.WriteLine(string.Format("The fourth elemet is: {0}\n", intTest.GetElementAt(4)));

            intTest.RemoveElementAt(4); // removing the fourth element
            Console.WriteLine(string.Format("When we removed fourth elemen we got:\n{0}", intTest));
            Console.WriteLine("capacity = " + intTest.Capacity + " count = " + intTest.Count + "\n");

            intTest.InsertElementAt(4, 4);
            Console.WriteLine(string.Format("When we inserted 4 for fourth elemen we got:\n{0}", intTest));
            Console.WriteLine("capacity = " + intTest.Capacity + " count = " + intTest.Count + "\n");

            //// to chjech that is capacity grow, wen insert a element
            int currentCapacity = intTest.Capacity;
            //// to be shure that we will overflow the capacity
            while (intTest.Count <= currentCapacity)
            {
                intTest.InsertElementAt(0, 0);
            }

            Console.WriteLine(string.Format("When we got overflow capacity, whit inserting elements in the front we got:\n{0}", intTest));
            Console.WriteLine("capacity = " + intTest.Capacity + " count = " + intTest.Count + "\n");

            Console.WriteLine(string.Format("When we checked for Index of \"5\" we got:\n{0}",  intTest.IndexOf(5)));
            Console.WriteLine(string.Format("When we checked for does it contain of \"19\" we got:\n{0}", intTest.Contains(19)));
            Console.WriteLine(string.Format("When we checked for the smallest element we got:\n{0}", intTest.Min()));
            Console.WriteLine(string.Format("When we checked for the biggest element we got:\n{0}", intTest.Max()));

            intTest.Clear();

            Console.WriteLine("When we claer array we got nothing :)");
            Console.WriteLine("capacity = " + intTest.Capacity + " count = " + intTest.Count + "\n");
        }

        private static void GetAttribute(Type type)
        {
            throw new NotImplementedException();
        }
    }
}