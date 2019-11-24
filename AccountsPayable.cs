using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsPayable
{
    class AccountsPayable
    {
        private string[] namesArray;
        private double[] payableArray;
        private string companyName;

        public string[] NamesArray
        {
            set { namesArray = value; }
        }
        public double[] PayableArray
        {
            set { payableArray = value; }
        }
        public string CompanyName
        {
            set { namesArray = value; }
        }

        public override string ToString()
        {
            double totalPayables = 0;
            double highestPayable = 0;
            string result = String.Format("Company Payables\n");
            for (int i = 0; i < namesArray.Length; i++)
            {
                result += String.Format("{0}\t{1:c}\n", namesArray[i], payableArray[i]);
                totalPayables += payableArray[i];
                if (payableArray[i] > highestPayable)
                {
                    highestPayable = payableArray[i];
                }
            }
            result += String.Format("Total payables: {0:c}\n", totalPayables);
            result += String.Format("Highest payable: {0:c}\n", highestPayable);
            return result;
        }

        public string GetPayable(string company)
        {
            string result = String.Format("Company not found\n");
            for (int i = 0; i < namesArray.Length; i++)
            {
                if (namesArray[i] == company.ToUpper)
                {
                    result = String.Format("{0} Payable is {1:c}\n", namesArray[i], payableArray[i]);
                }
            }
            return result;
        }
    }
}
