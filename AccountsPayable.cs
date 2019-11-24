using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsPayable
{
    class AccountsPayable
    {
        private string[] namesArray;
        private double[] payableArray;

        public string[] NamesArray
        {
            set { namesArray = value; }
        }
        public double[] PayableArray
        {
            set { payableArray = value; }
        }
    }
}
