namespace _01.StringBuilderExtensionss
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using _01.StringBuilderExtensions;

    public class TestStringBilderExtensions
    {
        public static void Main()
        {
            Console.WriteLine("starting String bilder is: Mila moq mamo sladka i dobrichka");
            Console.WriteLine();
            StringBuilder str = new StringBuilder("Mila moq mamo sladka i dobrichka");
            Console.WriteLine("Calling: str.Substring(14, str.Length)");
            Console.WriteLine(str.Substring(14, str.Length));
            Console.WriteLine();
            Console.WriteLine("Calling: str.RemoveText(\" sLaDkA I DoBrIcHkA\")");
            Console.WriteLine(str.RemoveText(" sLaDkA I DoBrIcHkA"));
            Console.WriteLine();
            Console.WriteLine("Callig: str.AppendAll(new List<string>(){ \" \", \"sladka\", \" i \", \"dobrichka\" })");
            List<string> removedText = new List<string>() { " ", "sladka", " i ", "dobrichka" };
            Console.WriteLine(str.AppendAll(removedText));
        }
    }
}