using System;
using System.Text.RegularExpressions;
/*Define a class Person that has name, age and email. The name and age are mandatory. 
 * The email is optional. Define properties that accept non-empty name and age in the range [1...100].
 * In case of invalid argument, throw an exception. Define a property for the email that accepts either 
 * null or non-empty string containing '@'. Define two constructors. The first constructor should take name, 
 * age and email. The second constructor should take name and age only and call the first constructor.
 * Implement the ToString() method to enable printing persons at the console.*/
public class TestPerson

{
    public static void Main()
    {
        ////Remove the comments to test the exeption massage ;)
        Person pesho = new Person("Petar", 25);
        Person gosho = new Person("Georgi", 27, "qkPich@pianici.bg");
        //Person moncho = new Person("Momchil", 23, "moncho@Monaha@BaiIlia.bg");
        Console.WriteLine(pesho.ToString());
        Console.WriteLine();
        Console.WriteLine(gosho.ToString());
        Console.WriteLine();
        //Console.WriteLine(moncho.ToString()); 
     }
}