using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumOfSubset
{
    class SumOfSubset
    {
        static void Main(string[] args)
        {
            string title = "IntDoubleOrString";
            string problem = @"We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 à 1+1-2=0.";
            Console.WriteLine("Titel:   " + title + "\n" + "Problem: " + problem);

            Console.WriteLine("Please, enter 5 veriables to see the greatest of them");
           
            int[] array = new int[5];
            for (int i = 1; i <= array.Length; i++)
            {
                Console.Write("number {0} :", i);

                array[i - 1] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int counter = 1;

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                if (sum == 0)
                {
                    for (int x = i; x < i + counter; x++)
                        {
                            Console.WriteLine(array[x] + ", ");
                        }
                        break;
                }
                else
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {

                        sum = sum + array[j];
                        counter++;
                        if (sum == 0)
                        {
                            for (int x = i; x < i + counter; x++)
                            {
                                Console.WriteLine(array[x] + ", ");
                            }
                            break;
                        }
                    }
                }
                counter = 1;
                sum = 0;
            }
           

        }
    }
}
