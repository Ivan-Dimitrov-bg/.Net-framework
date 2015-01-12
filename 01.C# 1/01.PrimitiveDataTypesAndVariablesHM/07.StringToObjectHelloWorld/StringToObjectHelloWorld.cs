using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.StringToObjectHelloWorld
{
    class StringToObjectHelloWorld
    {
        static void Main()
        {
            string title = "StringToObjectHelloWorld";
            string problem = @"Declare two string variables and assign them with “Hello” and “World”. 
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).";
            Console.WriteLine(title + "\n" + problem + "\n");

            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string helloWorldString = Convert.ToString(helloWorld);

            Console.WriteLine(helloWorldString);


        }
    }
}
