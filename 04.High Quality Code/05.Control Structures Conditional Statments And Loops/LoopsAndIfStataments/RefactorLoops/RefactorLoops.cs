using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoopsAndIfStataments
{
    class RefactorLoop
    {
        public static void Main()
        {
            int[] array = new int[100];
            int expectedValue = 666;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                    }
                }
            }
        }
    }
}
