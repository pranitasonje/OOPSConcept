using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            AbsDerivedClass abs = new AbsDerivedClass();
            Console.WriteLine(abs.GetFileDetails());
            Console.ReadLine();
        }
    }

    public abstract class ClassPdfCreation
     {   
       public void CreatePdfDoc()
       {

       }
      
       public void Printproduct()
       {

       }
       public abstract string GetFilePath();
       public virtual string GetFileDetails()
       {
        string fileContact = "Testing Abstract and Virtual";
        return fileContact;
       }
     }

    public class AbsDerivedClass : ClassPdfCreation
    {
       public override string GetFilePath()
       {
           string filepath = @"C:\demo\testfile.txt";
           return filepath;
       }

       public override string GetFileDetails()
       {
          string fileContact = "This is after the virtual override";
          return fileContact;
       }
    }
}