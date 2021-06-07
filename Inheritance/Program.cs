using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassProduct product = new ClassProduct();
            product.CreatePdfDoc();
            product.Printproduct();

            ClassCustomer customer = new ClassCustomer();
            customer.CreatePdfDoc();
            customer.Printproduct();
        }
    }

    public class ClassPdfCreation
    {
        public void CreatePdfDoc()
        {
            //string str;
            ClassProduct output = new ClassProduct();
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {

            }
        }
        public void Printproduct()
        {
            //    Process printProcess = new Process();
            //    printProcess.StartInfo = printProcessInfo;
            //    printProcess.Start();
        }
    }

    public class ClassCustomer : ClassProduct
    {
        public int customId { get; set; }
        public string customName { get; set; }
        public string DelivaryAddress { get; set; }
    }
    public class ClassProduct : ClassPdfCreation
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
    }

}
