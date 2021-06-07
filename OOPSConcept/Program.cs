using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount obj = new BankAccount();
            customDetails cusomDetails = new customDetails();
            obj.GetcustomDetails();
        }
    }

    class BankAccount
    {
        public customDetails GetcustomDetails()
        {
            customDetails custom = new customDetails();

            custom.AccountNumber = 3645975674;
            custom.CustomName = "PrivilageCustomer";
            //custom.Atmpin = 5687;
            return custom;
        }
    }
}