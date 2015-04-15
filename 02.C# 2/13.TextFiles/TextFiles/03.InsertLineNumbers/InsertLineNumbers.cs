//Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text fi    le.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InsertLineNumbers
{
    class InsertLineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("subs.txt", Encoding.GetEncoding("windows-1251"));
        }
    }
}
