using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortThreeValue
{
    class SortThreeValue
    {
        static void Main()
        {
            string title = "SortThreeValues";
            string problem = "Sort 3 real values in descending order using nested if statements.";
            Console.WriteLine("Titel:   " + title + "\n" + "Problem: " + problem);

            Console.WriteLine("Please, enter three numbers: ");
            Console.Write("First :");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Second :");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Third :");
            int thirdNumber = int.Parse(Console.ReadLine());

            int numberOne = 0;
            int numberTwo = 0;
            int numberThree = 0;

            if (firstNumber > secondNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    numberOne = firstNumber;
                    numberTwo = secondNumber;
                    numberThree = thirdNumber;
                }
                else if (thirdNumber > firstNumber)
                {
                    numberOne = firstNumber;
                    numberTwo = thirdNumber;
                    numberThree = secondNumber;
                }
            }
            else
            {
                if (firstNumber > thirdNumber)
                {
                    numberOne = secondNumber;
                    numberTwo = firstNumber;
                    numberThree = thirdNumber;
                }
                else if (thirdNumber > secondNumber)
                {
                    numberOne = thirdNumber;
                    numberTwo = secondNumber;
                    numberThree = firstNumber;
                }
            }
            Console.WriteLine("1. {0} \n2. {1} \n3. {2}", numberOne, numberTwo, numberThree);

        }
    }
}
