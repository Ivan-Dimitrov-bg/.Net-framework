using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExchangeInt
{
    class ExchangeInt
    {
        static void Main(string[] args)
        {
            string title = "ExchangeInt";
            string problem = @"11. Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.";
            Console.WriteLine(title + "\n" + problem + "\n");

            int firstValue = 5;
            int secondValue = 10;
            Console.WriteLine(" First Value = {0} \n Second value = {1}", firstValue, secondValue);
            int thirdValue = new int();
            thirdValue = firstValue;
            firstValue = secondValue;
            secondValue = thirdValue;

            Console.WriteLine("After Exchange \n First Value = {0} \n Second value = {1}", firstValue, secondValue);
        }
    }
}
