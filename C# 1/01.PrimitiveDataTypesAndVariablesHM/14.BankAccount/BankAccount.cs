using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BankAccount
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            string title = "BankAccount";
            string problem = @"14. A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names";
            Console.WriteLine(title + "\n" + problem + "\n");
            string firstName, secondNme, lastName, bankName, countryCode = "BG", identificationOfBank = "UNCR", locationCodeOfBic = "BG";
            decimal balance;
            int lastNumbersFromIBAN = 12345678;
            byte controlNumber = 12, accoutnType = 11;
            ushort identificationOfBau = 8547;
            object IBAN, BICCode;
            long firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber;
            firstName = "Ivan";
            secondNme = "Dimitrov";
            lastName = "Dimitrov";
            bankName = "DSK";
            balance = 123456789;
            IBAN = countryCode + controlNumber + identificationOfBank + identificationOfBau + accoutnType + lastNumbersFromIBAN;
            BICCode = identificationOfBank + countryCode + locationCodeOfBic;
            firstCreditCardNumber = 4532545287906807l;
            secondCreditCardNumber = 4929519098609950l;
            thirdCreditCardNumber = 4485718615422733l;
            Console.WriteLine("First Name: {0}\nSecond name: {1}\nLast name: {2}\nBank name: {3}\nBalance: {4}\nIBAN: {5}\nBICCode: {6}\nFirst Credit card number: {7}\nSecond Credit card number: {8}\nThird Credit card number: {9}\n", firstName, secondNme, lastName, bankName, balance, IBAN, BICCode, firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
