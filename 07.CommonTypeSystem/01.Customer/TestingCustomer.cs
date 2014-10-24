namespace _01.Customer
{
    using System;
    using System.Collections.Generic;

    public class TestingCustomer
    {
        public static void Main() 
        {
            Customer pesho = new Customer(
                "Pesho",
                "Gosshev",
                "Migdin",
                "8204307743",
                "Sofia, ul. \"Klokotnitsa\"",
                "0887687001",
                "astala.vista.sista@redi.rimi.bg",
                new List<Payment>() { new Payment("motika", 20), new Payment("lopata", 22) },
                CustomerType.Golden);

            Console.WriteLine(pesho);
            Console.WriteLine();

            Customer peshoCloning = pesho.Clone() as Customer;

            peshoCloning.FirstName = "Gosho";
            peshoCloning.Type = CustomerType.Regular;
            peshoCloning.Payments = new List<Payment>() { new Payment("kopach", 10), new Payment("tenta", 220) };
            Console.WriteLine(peshoCloning);
            Console.WriteLine("\nPesho after cloning:");
            Console.WriteLine(pesho);

            Console.WriteLine();
            Console.WriteLine(string.Format("Is Pesho the same persan as Gosho?\nAnswer: {0}!", pesho == peshoCloning));

            peshoCloning.Id = "8104234462";
            Console.WriteLine("If we change cloning id to 8104234462!");
            Console.WriteLine(string.Format("Is Pesho the same persan as Gosho?\nAnswer: {0}!", pesho == peshoCloning));
            Console.WriteLine();
            Console.WriteLine("Is pesho greater than pesho`s cloning (Gosho)?");
            if (pesho.CompareTo(peshoCloning) > 1)
            {
                Console.WriteLine("Answer: yes!");
            }
            else
            {
                Console.WriteLine("Answer: no!");
            }
        }
    }
}
