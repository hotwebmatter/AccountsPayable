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

    }
}
