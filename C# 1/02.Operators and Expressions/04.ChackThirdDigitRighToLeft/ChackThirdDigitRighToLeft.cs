using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ChackThirdDigitRighToLeft
{
    class ChackThirdDigitRighToLeft
    {
        static void Main(string[] args)
        {
            string title = "ChackThirdDigitRighToLeft";
            string problem = "Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 à true.";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.Write("Please enter some integer: ");
            int someInt = int.Parse(Console.ReadLine());

            bool result = false;
            if (someInt >= 700)
            {
                int checkThird = (someInt / 100) % 10;
                result = checkThird == 7 ? true : false;
                Console.WriteLine("Is third digit 7? {0}", result);
            }
            else
            {
                Console.WriteLine("The number is smoller than 700");
            }
            
        }
    }
}
