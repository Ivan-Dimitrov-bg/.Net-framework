//Write a program that generates and prints to the console 10 random values in the range [100, 200].
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomValuesInRange
{
    class RandomValuesInRange
    {
        static void Main(string[] args)
        {
            int startNumber = 100;
            int endNumber = 201;
            int numberOfRandomNumbers = 10;
            List<int> randomNumbers = new List<int>();
            randomNumbers = GetRandomNumber(startNumber, endNumber, numberOfRandomNumbers);
            PrintRandomNumbers(randomNumbers);
        }

        private static void PrintRandomNumbers(List<int> randomNumbers)
        {
            foreach (var item in randomNumbers)
            {
                Console.Write(item + " ");
            }
        }

        private static List<int> GetRandomNumber(int startNumber, int endNumber, int numberOfRandomNumbers)
        {
            List<int> randomNumbers = new List<int>();
            Random randomNumber = new Random();
            for (int i = 0; i < numberOfRandomNumbers; i++)
            {
                randomNumbers.Add(randomNumber.Next(startNumber, endNumber));
            }
            return randomNumbers;
        }

       
    }
}
