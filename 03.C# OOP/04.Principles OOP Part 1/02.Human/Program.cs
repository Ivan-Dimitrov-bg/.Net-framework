using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Human
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 students and sort them y grade in ascending order.
            List<Student> students = new List<Student>()
            {
                new Student ("Toni","Petrov", 9 ),
                new Student ("Ivan","Petrov", 7 ),
                new Student ("Hristo","Petrov", 3 ),
                new Student ("Toni","Petrov", 4 ),
                new Student ("Toni","Petrov", 5 ),
                new Student ("Toni","Petrov", 6 ),
                new Student ("Toni","Petrov", 7 ),
                new Student ("Toni","Petrov", 8 ),
                new Student ("Toni","Petrov", 8 ),
                new Student ("Toni","Petrov", 8 ),
                new Student ("Toni","Petrov", 8 ),
            };
            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " Grade = " + item.Grade);
            }

            students = students.OrderBy(student => student.Grade).ToList();

            Console.WriteLine("******* Sorted *******");
            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " Grade = " + item.Grade);
            }

            // 10 workers
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Ivan", "Hristov", 350, 20),
                new Worker("Petyr", "Hristov", 150, 40),
                new Worker("Toni", "Hristov", 250, 40),
                new Worker("Momchil", "Hristov", 150, 40),
                new Worker("Hristo", "Hristov", 350, 10),
                new Worker("Ivo", "Hristov", 150, 10),
                new Worker("Ivan", "Hristov", 2150, 30),
                new Worker("Ivan", "Hristov", 210, 20),
                new Worker("Ivan", "Hristov", 150, 10),

            };
            foreach (var item in workers)
            {
                Console.WriteLine(item.FirstName + " Money per Hour= " + item.MoneyPerHour());
            }
            Console.WriteLine("***Merged list and Sorted****");
            var mergedlists = workers.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();
            foreach (var item in mergedlists)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

        }
    }
}
