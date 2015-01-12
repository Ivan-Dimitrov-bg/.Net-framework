using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComparesCharArray
{
    class ComparesCharArray
    {
        static void Main(string[] args)
        {
            string titel = "ComparesCharArray";
            string problem = @"Write a program that compares two char arrays lexicographically (letter by letter).";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.WriteLine("Please, the size on the first Array");
            int nOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, the size on the second Array");
            int nTwo = int.Parse(Console.ReadLine());

            char[] arrayOne = new char[nOne];
            char[] arrayTwo = new char[nTwo];
            int counter = 0;

            Console.WriteLine("Please enter {0} elements and fill first array", nOne);
            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayOne[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter {0} elements and fill first array", arrayTwo);
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                arrayTwo[i] = char.Parse(Console.ReadLine());
            }

            if (nOne > nTwo)
            {
                Console.WriteLine("The first array has more elements than the second");
                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    if (arrayOne[i] == arrayTwo[i])
                    {
                        Console.WriteLine("The element {0} : ({1}) equal to ({2})", i, arrayOne[i], arrayTwo[i]);
                    }
                    else
                    {
                        Console.WriteLine("The element {0} : ({1}) not equal to ({2})", i, arrayOne[i], arrayTwo[i]);
                    }
                }
                Console.WriteLine("There is no more elements into array Two to be compared");


            }
            else if (nTwo > nOne)
            {
                Console.WriteLine("THe second array has more elements then the first");
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i] == arrayTwo[i])
                    {
                        Console.WriteLine("The element {0} : ({1}) equal to ({2})", i, arrayOne[i], arrayTwo[i]);
                    }
                    else
                    {
                        Console.WriteLine("The element {0} : ({1}) not equal to ({2})", i, arrayOne[i], arrayTwo[i]);
                    }
                }
                Console.WriteLine("There is no more elements into array Two to be compared");
            }
            else
            {             
                Console.WriteLine("the First array anad the second array has the equal elements");
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i] == arrayTwo[i])
                    {
                        Console.WriteLine("The element {0} : ({1}) equal to ({2})", i, arrayOne[i], arrayTwo[i]);
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("The element {0} : ({1}) not equal to ({2})", i, arrayOne[i], arrayTwo[i]);
                    }
                }

            }
            if (counter == nOne)
            {
                Console.WriteLine("Arrays are lexicographically equal");
            }
            else
            {
                Console.WriteLine("Array are not lexicographically equal.");
            }



        }
    }
}
