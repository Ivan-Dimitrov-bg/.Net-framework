using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public static class Substring
    {
        public static StringBuilder ExtendSB(this StringBuilder sb, int start, int length)
        {
            StringBuilder local = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                local.Append(sb[start + i]);
            }
            return local;
        }

        static void Main(string[] args)
        {            
            StringBuilder example = new StringBuilder();
            //example.Append("9876543210");
            example.Append("Eva Longoria");
            Console.WriteLine(example.ExtendSB(4, 4));
            Console.WriteLine(example.ExtendSB(0, 5));
        }
    }
