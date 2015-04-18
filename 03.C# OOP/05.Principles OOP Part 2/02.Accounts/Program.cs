//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.bankClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Customers> customersList = new List<Customers>();
            customersList.Add(new Individuals(20, "Pesho", "M"));
            customersList.Add(new Individuals(100, "Kiro", "M"));
            customersList.Add(new Companies("Krada vsichko OOD", 9999));
            customersList.Add(new Companies("Fantom OOD", 1212));
            customersList.Add(new Companies("Kyrti i izvozva", 5432));
            List<Accounts> accountsList = new List<Accounts>();
            accountsList.Add(new DepositAccount(customersList[0], 1010, 0.06m, 10)); // same parameteres to see the diference
            accountsList.Add(new DepositAccount(customersList[1], 2000, 0.1m, 10));
            accountsList.Add(new DepositAccount(customersList[2], 1000, 0.06m, 10));
            accountsList.Add(new LoanAccount(customersList[3], 1000, 0.06m, 10)); //after override
            accountsList.Add(new MortgageAccount(customersList[4], 1000, 0.06m, 10));

            foreach (var account in accountsList)
            {
                Console.WriteLine(account.CalculateInterest());
                account.Deposit(2000);
                if (account is DepositAccount)
                {
                    account.Drow(100);
                    Console.WriteLine("I 've just drow out some money");
                }
            }
        }
    }
}