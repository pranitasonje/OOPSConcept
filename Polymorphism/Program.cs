using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Normal Process
            StaticDemo obj = new StaticDemo();
                obj.GetStudentID("Pranita");

            //static
            StaticDemo.GetStudentID("Pranita","Mumbai");

                customDetails custom = new customDetails();

                bool res1 = custom.GetCash("6787 4576 5698 6787");
                bool res2 = custom.GetCash(67899666);
                bool res3 = custom.GetCash("6787 4576 5698 6787", 67899666);         
        }
    }
    public class customDetails
   {
    public customDetails()
    {

    }
    public customDetails(int number)
    {

    }
    public customDetails(string name)
    {

    }
    public long AccountNumber { get; set; }
    public string customName { get; set; }
     private int Atmpin {get; set; }

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
    public bool GetCash(string CardNumber)
    {
        if (CardNumber == "6787 4576 5698 6787")
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
    public bool GetCash(string CardNumber, long AccountNumber)
    {
        if (CardNumber == "6787 4576 5698 6787" || AccountNumber == 67899666)
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
    public bool GetCash(decimal CardNumber)
    {
        if (CardNumber == 45876)
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
