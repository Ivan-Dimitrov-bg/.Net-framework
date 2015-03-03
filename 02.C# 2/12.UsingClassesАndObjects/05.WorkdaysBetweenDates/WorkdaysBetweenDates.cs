//5.Write a method that calculates the number of workdays between today and given date, 
//passed as parameter. Consider that workdays are all days from Monday to Friday except a
//fixed list of public holidays specified preliminary as array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WorkdaysBetweenDates
{
    class WorkdaysBetweenDates
    {
        static void Main()
        {
            Console.WriteLine("Please, enter some date. Format year, mm, dd. The program will show how many work days exist between the the chosen date and today");
            Console.WriteLine("year = ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("mounth = ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("day = ");
            int day = int.Parse(Console.ReadLine());

            DateTime startDay = DateTime.Today;
            DateTime endDay = new DateTime(year, month, day);
            int timeDifference = 0;
            if (startDay > endDay)// if start Day is bigger then the end Day - we switch them
            {
                startDay = endDay;
                endDay = DateTime.Today;
            }
            timeDifference = Math.Abs((endDay - startDay).Days);
            Console.WriteLine("The time difference in days is: {0}", timeDifference);

            DateTime[] holidays =
            {
                new DateTime(2015, 1, 1),
                new DateTime(2015, 3, 3),
                new DateTime(2015, 5, 1),
                new DateTime(2015, 5, 3),
                new DateTime(2015, 5, 4),
                new DateTime(2015, 5, 5),
                new DateTime(2015, 5, 6),
                new DateTime(2015, 5, 24),
                new DateTime(2015, 9, 6),
                new DateTime(2015, 9, 22),
                new DateTime(2015, 12, 24),
                new DateTime(2015, 12, 25),
                new DateTime(2015, 12, 26),
                new DateTime(2015, 12, 31),
            };
        int workDayCounter = 0;
        bool isHoliday = false;
        for (int i = 0; i < timeDifference; i++)
        {
            startDay = startDay.AddDays(1);
            if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDay == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday) // If isHoliday is false work DayCounter + 1
                {
                    workDayCounter++;
                }

                isHoliday = false;
            }
        }
        Console.WriteLine("The work Days is: {0} ",workDayCounter);

    }
}
