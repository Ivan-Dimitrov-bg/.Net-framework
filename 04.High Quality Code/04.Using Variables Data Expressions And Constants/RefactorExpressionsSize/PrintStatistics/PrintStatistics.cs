using System;

namespace Task02RefactorPrintStatistics
{
    class PrintStatistics
    {
        public void PrintStatistics(double[] array, int limit)
        {
            PrintMaxElement(array, limit);
            PrintMinElement(array, limit);
            PrintAverage(array, limit);
        }

        public void PrintMinElement(double[] array, int limit)
        {
            double minElement = array[0];

            for (int i = 1; i < limit; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                }
            }

            Console.WriteLine(minElement);
        }

        public void PrintMaxElement(double[] array, int limit)
        {
            double maxElement = array[0];

            for (int i = 1; i < limit; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }

            Console.WriteLine(maxElement);
        }

        public void PrintAverage(double[] array, int limit)
        {
            double sumOfTheElements = 0;

            for (int i = 0; i < limit; i++)
            {
                sumOfTheElements += array[i];
            }

            double average = sumOfTheElements / limit;
            Console.WriteLine(average);
        }
    }
}