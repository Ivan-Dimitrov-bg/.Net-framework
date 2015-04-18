using System;

    class Generics
    {
        static void Main(string[] args)
        {
            //предполагаме че типа е числен за да използвам за метода clear зануляване
            GenericList<string> Proba = new GenericList<string>(8);
            GenericList<decimal> Example = new GenericList<decimal>(18);
            Console.WriteLine(Example.ToString());
        }
    }