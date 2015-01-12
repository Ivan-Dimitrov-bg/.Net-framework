using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MarketingRecord
{
    class MarketingRecord
    {
        static void Main(string[] args)
        {
            string title = "MarketingRecord";
            string problem = @"A marketing firm wants to keep record of its employees. 
Each record would have the following characteristics – 
first name, family name, age, gender (m or f), ID number, 
unique employee number (27560000 to 27569999). 
Declare the variables needed to keep the information for a 
single employee using appropriate data types and descriptive names.";

            Console.WriteLine(title + "\n" + problem + "\n");

            string firstName = "Ivan", familyName = "Dimitrov";
            byte age = 28;
            char gender = 'M';
            int ID = 354985;
            int uniqueEmployeeNumber = 27569999;
            Console.WriteLine("Employee: {0} {1}\nAge: {2}\nGender: {3}\nEmployee ID: {4}\nUnique emplyee number: {5}",firstName,familyName, age, gender, ID, uniqueEmployeeNumber);


        }
    }
}
