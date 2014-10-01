using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PringInfoAboutCompany
{
    class PringInfoAboutCompany
    {
        static void Main()
        {
            string titel = "PringInfoAboutCompany";
            string problem = @"A company has 
                    name, 
                    address, 
                    phone number, 
                    fax number, 
                    web site and manager. 
                    The manager has 
                        first name, 
                        last name, 
                        age and a 
                        phone number. 
Write a program that reads the information about a company and its manager and prints them on the console.";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);
            Console.Write("Please, enter company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Please, enter company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Please, enter company phone number: ");
            int companyPhoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Please, enter company fax number: ");
            int companyFaxNumber = int.Parse(Console.ReadLine());
            Console.Write("Please, enter website: ");
            string companyWebsite = Console.ReadLine();

            Console.Write("Please, enter manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Please, enter manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Please, enter manager age : ");
            int managerAge = int.Parse(Console.ReadLine());
            Console.Write("Please, enter manager phone number : ");
            int phoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Information about Company: \n name:  {0}, \n address: {1} \n phone number: {2} \n fax number: {3} \n web site: {4} \n Company Manager: \n  name: {5} {6} \n  age: {7} \n  Phone number: {8}",
              companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebsite, managerFirstName, managerLastName, managerAge, phoneNumber);
        }
    }
}