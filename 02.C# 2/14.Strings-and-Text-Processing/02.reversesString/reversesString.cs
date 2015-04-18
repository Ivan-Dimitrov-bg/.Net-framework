//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

using System;

class reversesStrring
{
    static void Main()
    {
        string str = "sample";

        char[] strArray = str.ToCharArray();
        Array.Reverse(strArray);// преобръщаме масива

        Console.WriteLine(strArray); // we can print array of chars directlly 
        // see overload method // http://www.dotnetperls.com/overload

    }

}