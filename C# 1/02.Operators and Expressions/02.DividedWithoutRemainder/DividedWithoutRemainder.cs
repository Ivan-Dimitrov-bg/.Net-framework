using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DividedWithoutRemainder
{
    class DividedWithoutRemainder
    {
        static void Main(string[] args)
        {
            string title = "DividedWithoutRemainder";
            string problem = "Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.WriteLine("Please enter some integer");
            int someInteger = int.Parse(Console.ReadLine());
            int firstChack = 5;
            int secondChack = 7;

            string result = (someInteger % firstChack == 0 & someInteger % secondChack == 0) ? "Yes" : "No";
            Console.WriteLine("Can integer {0} , be divided to {1} and {2} without remainder: {3}", someInteger, firstChack, secondChack, result);


        }
    }
}
