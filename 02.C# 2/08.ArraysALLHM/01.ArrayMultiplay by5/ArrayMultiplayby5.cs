using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayMultiplay_by5
{
    class ArrayMultiplayby5
    {
        static void Main(string[] args)
        {
            string titel = "ArrayMultiplayby5";
            string problem = @"Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);


            int[] array = new int [20]{1, 2, 3, 4, 5, 6, 7, 8, 9, 100, 11, 12, 13, 14, 15, 16, 17, 18, 19, 200};
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} = ", array[i]);

                array[i] = array[i] * 5;
                Console.WriteLine(array[i]);
            }


        }
    }
}
