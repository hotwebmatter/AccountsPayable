/**
 * ######################################################
 * ##    Programming Assignment #13                    ##
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
            Write(GenerateHeader());
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
