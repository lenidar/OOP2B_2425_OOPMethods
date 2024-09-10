using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2B_2425_OOPMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                //Console.WriteLine($"Hello there {args[0]}");
                Console.WriteLine("I have many things to say...");
                foreach(string arg in args)
                {
                    Console.WriteLine(arg);
                }
            }
            else
            {
                Console.WriteLine("Hello, welcome!");
            }

            baseMethod();

            sumTwoNum(8, 5);
            sumTwoNumWDef(2,2);
            sumTwoNumWDef(2, 3);

            Console.WriteLine(methodWReturn());
            Console.WriteLine(methodWReturnNThings());

            Console.WriteLine(userInputOutNumber("Please give me a number..."));

            sumTwoNum(userInputOutNumber("What is the first number"), userInputOutNumber("What is the second number"));

            Console.ReadKey();
        }

        static void baseMethod()
        {
            Console.WriteLine("This message comes from the base method...");
        }

        static void sumTwoNum(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is {a + b}");
        }

        static void sumTwoNumWDef(int a = 8, int b = 7)
        {
            Console.WriteLine($"The sum of {a} and {b} is {a + b}");
        }

        static string methodWReturn()
        {
            return "I have returned!";
        }

        static string methodWReturnNThings()
        {
            return "I have returned AGAIN!";
            Console.WriteLine("I am plotting to overthrow you...");
        }

        static int userInputOutNumber(string question)
        {
            string uInput = "";
            int num = 0;
            while (true)
            {
                Console.WriteLine(question);
                uInput = Console.ReadLine();

                try
                {
                    num = int.Parse(uInput);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("That is not a number...");
                }
            }

            return num;
        }
    }
}
