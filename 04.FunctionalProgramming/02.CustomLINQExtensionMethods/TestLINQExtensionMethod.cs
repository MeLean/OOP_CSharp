namespace _02.CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;

    class TestLINQExtensionMethod
    {
        public static void Main()
        {
            
            List<string> strCollection = new List<string>() { "one", "two", "three", "four", "five" };
            Console.WriteLine("The main List of strings: { \"one\", \"two\", \"three\", \"four\", \"five\" } ");

            Console.WriteLine("\nCalling WhereNot(x => x.Length > 3):");
            var result = strCollection.WhereNot(x => x.Length > 3);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCalling Repeat(2):");
            var repeatedCollection = strCollection.Repeat(2);

            foreach (var item in repeatedCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCalling WhereEndsWith(Array{\"e\", \"r\"})");
            string[] strArr = {"e", "r"};

            var endingWhitSufix = strCollection.WhereEndsWith(strArr);

            foreach (var item in endingWhitSufix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
