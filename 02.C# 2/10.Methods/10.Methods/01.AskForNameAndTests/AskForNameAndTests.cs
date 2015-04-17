//Write a method that asks the user for his name and prints “Hello, <name>” 
//(for example, “Hello, Peter!”). Write a program to test this method.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AskForNameAndTests
{
    class AskForNameAndTests
    {
        static void Main()
        {
            sayHello();
        }

        private static void sayHello()
        {
            Console.Write("Enter, your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
    }
}
