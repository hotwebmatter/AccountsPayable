/**
 * ######################################################
 * ##    Programming Assignment #12                    ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: November 17 2019              ##
 * ##    Purpose: Demonstrate parallel arrays          ##
 * ######################################################
 */
using System;
using static System.Console;


namespace AccountsPayable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesArray = { "PEARSON", "CENGAGE", "WILEY", "MURARCH" };
            double[] payableArray = { 25000, 37000, 10000, -500 };
            Write(GenerateHeader());
            AccountsPayable myAccountsPayable = new AccountsPayable();
            myAccountsPayable.NamesArray = namesArray;
            myAccountsPayable.PayableArray = payableArray;
            WriteLine(myAccountsPayable.ToString());
            Write("Enter name of company: ");
            myAccountsPayable.CompanyName = ReadLine();
            WriteLine();
            WriteLine(myAccountsPayable.GetPayable());
            WriteLine("*********************************************");
        }

        public static string GenerateHeader()
        {
            string result;
            result = String.Format("*********************************************\n");
            result += String.Format("\tAccounts Payable\n");
            result += String.Format("\tSearch Array and Display Money Owed\n");
            result += String.Format("\tMatthew Obert\n");
            result += String.Format("\tNovember 24 2019\n");
            result += String.Format("*********************************************\n");
            result += String.Format("This program will display money owed\n\n");
            result += String.Format("Enter the company's name to determine\n");
            result += String.Format("  money owed by that company\n");
            result += String.Format("*********************************************\n");
            return result;
        }
    }
}
