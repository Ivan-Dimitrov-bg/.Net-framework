using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ShowSign
{
    class ShowSign
    {
        static void Main()
        {
            string title = "ShowSign";
            string problem = "Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.";
            Console.WriteLine("Titel:   " + title + "\n" + "Problem: " + problem);

            Console.WriteLine("Please, enter three numbers: ");
            Console.Write("First :");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Second :");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Third :");
            int thirdNumber = int.Parse(Console.ReadLine());

            if ((firstNumber < 0 && secondNumber < 0 && thirdNumber < 0) || 
               (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0) ||
               (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0) ||
               (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0))
            {
                Console.WriteLine(@"The sign of the product of this three numbers is: (-)");    
            }
            else
            {
                Console.WriteLine(@"The sign of the product of this three numbers is: (+)"); 
            }


        }
    }
}
