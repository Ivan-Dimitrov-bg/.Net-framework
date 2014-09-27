using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            string title = "OddOrEven";
            string problem = "Write an expression that checks if given integer is odd or even.";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.WriteLine("Please enter sume integer");
            int someInteger = int.Parse(Console.ReadLine());

            string result = someInteger % 2 == 1 ? "odd" : "even";
            Console.WriteLine("The number {0} is {1}",someInteger, result);

            //second way
            /*
            if (someInteger % 2 == 1)
            {
                Console.WriteLine("The integer {0} in odd ", someInteger);
            }
            else
            {
                Console.WriteLine("The integer {0} in even ", someInteger);
            }
            */
        }
    }
}
