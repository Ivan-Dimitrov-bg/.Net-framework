using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangeValues
{
    class ExchangeValues
    {
        static void Main()
        {
            string title = "ExchangeValues";
            string problem = "Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.";
            Console.WriteLine("Titel:   " + title + "\n" + "Problem: " + problem);

            Console.Write("Please, whrite first value: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please, whrite second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First number is bigger than second we exchange there values");
                int thirdNumber = 0;
                thirdNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }


            Console.WriteLine("firstNumber: {0} \n secondNumber: {1}", firstNumber, secondNumber);

        }
    }
}
