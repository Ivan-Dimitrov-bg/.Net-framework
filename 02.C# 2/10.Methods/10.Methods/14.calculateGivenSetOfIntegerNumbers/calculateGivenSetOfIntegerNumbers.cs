//Write methods to calculate minimum, maximum, average,
//sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;

namespace Task14LotsOfCalcs
{
    class Task14LotsOfCalcs
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("How many numbers are in the sequence? ");
                    int sequence = int.Parse(Console.ReadLine());
                    double[] myArray = new double[sequence];
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        Console.Write("Enter {0} number ", i);
                        myArray[i] = double.Parse(Console.ReadLine());
                    }

                    Console.WriteLine();
                    double finalMin = Minimum(myArray);
                    Console.WriteLine("The lowest number from the sequence is: {0}", finalMin);
                    double finalmax = Maximum(myArray);
                    Console.WriteLine("The greatest number in the sequence is: {0}", finalmax);
                    double finalSum = Sum(myArray);
                    Console.WriteLine("The sum of all the numbers in the sequence is: {0}", finalSum);
                    double finalAverage = Average(myArray);
                    Console.WriteLine("The average value of all the numbers in the sequence is: {0}", finalAverage);
                    double finalProduct = Product(myArray);
                    Console.WriteLine("The product of all the numbers in the sequence is: {0}", finalProduct);
                }
                catch
                {
                    Console.WriteLine("Please enter a number");
                } 
            }
            
        }

        static double Minimum(params double[] arr)
        {
            double lowest = double.MaxValue;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] <= lowest)
                {
                    lowest = arr[j];
                }
            }

            return lowest;
        }

        static double Maximum(params double[] arr)
        {
            double greatest = double.MinValue;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] >= greatest)
                {
                    greatest = arr[j];
                }
            }

            return greatest;
        }

        static double Sum(params double[] arr)
        {
            double sum = 0;
            for (int k = 0; k < arr.Length; k++)
            {
                sum = sum + arr[k];
            }

            return sum;
        }

        static double Average(params double[] arr)
        {
            double average = Sum(arr) / arr.Length;
            return average;
        }

        static double Product(params double[] arr)
        {
            double product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product = product * arr[i];
            }

            return product;
        }
    }
}
