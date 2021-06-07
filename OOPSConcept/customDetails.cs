using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class customDetails
    {
        public long AccountNumber { get; set; }
        public string CustomName { get; set; }
        private int Atmpin { get; set; }

        public bool GetCash(long AccountNumber)
        {
            if (AccountNumber == 67899666)
            {
                if (Atmpin == 5687)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            return false;
        }
    }

}
