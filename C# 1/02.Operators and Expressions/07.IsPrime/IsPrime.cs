using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.IsPrime
{
    class IsPrime
    {
        static void Main(string[] args)
        {
            string title = "IsPrime";
            string problem = "Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.Write("Please enter some integer Number: ");
            int someInt = int.Parse(Console.ReadLine());
            bool Isprime = true;
            //optimization
            int upper = (int)Math.Sqrt(someInt);

            for (int i = 2; i < upper; i++)
			{
                if (someInt % i == 0)
                {
                    Isprime = false;
                    break;
                }
			}
            Console.WriteLine("The number is Prime? {0}", Isprime);
        }
    }
}
