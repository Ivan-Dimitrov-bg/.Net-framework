using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Students
    {
        class Student
        {
            public string name { get; set; }
            public string family { get; set; }
            public int age { get; set; }

            public Student(string first, string second, int years)
            {
                this.name = first;
                this.family = second;
                this.age = years;
            }
        }

        static void Main(string[] args)
        {
            Student[] ninjas = new Student[6];
            ninjas[0] = new Student("Mitko", "Georgiev", 20);
            ninjas[1] = new Student("Petar", "Kostov", 25);
            ninjas[2] = new Student("Mihail", "Georgiev", 18);
            ninjas[3] = new Student("Petar", "Petrov", 22);
            ninjas[4] = new Student("Nadq", "Stefanova", 27);
            ninjas[5] = new Student("Nadq", "Yanakieva", 21);

            var orderedStudents =
                from nin in ninjas
                where (nin.family.CompareTo(nin.name) > 0)
                select nin;

            var young =
                from nin in ninjas
                where (nin.age >= 18 && nin.age <= 24)
                select nin;

            var Alphabetic =
                ninjas.OrderByDescending(a => a.name).ThenByDescending(a => a.family);

            var Alphabetic2 =
                from nin in ninjas
                orderby nin.name descending, nin.family descending
                select nin;

          
            Console.WriteLine("problem 3");
            foreach (Student st in orderedStudents)
            {
                Console.WriteLine(st.name + "  " + st.family);
            }

            Console.WriteLine();
            Console.WriteLine("problem 4");
            foreach (Student st in young)
            {
                Console.WriteLine(st.name + "  " + st.family);
            }

            Console.WriteLine();
            Console.WriteLine("problem 5a");
            foreach (Student st in Alphabetic)
            {
                Console.WriteLine(st.name + "  " + st.family);
            }

            Console.WriteLine();
            Console.WriteLine("problem 5b");
            foreach (Student st in Alphabetic2)
            {
                Console.WriteLine(st.name + "  " + st.family);
            }
        }
    }


/* List<int> list = new List<int>() { 1, 2, 3, 4 };
List<int> evenNumbers = 
  list.FindAll(x => (x % 2) == 0);
foreach (var num in evenNumbers)
{
    Console.Write("{0} ", num);
}
Console.WriteLine();
// 2 4

list.RemoveAll(x => x > 3); // 1 2 3 */
