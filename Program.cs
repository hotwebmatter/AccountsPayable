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
            result = String.Format("*********************************************");
            result += String.Format("\tAccounts Payable");
            result += String.Format("\tSearch Array and Display Money Owed");
            result += String.Format("\tMatthew Obert");
            result += String.Format("\tNovember 24 2019");
            result += String.Format("*********************************************");
            return result;
        }
    }
}
