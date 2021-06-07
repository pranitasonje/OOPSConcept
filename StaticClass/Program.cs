using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DashBoard dash = new DashBoard();
            dash.AddNumber();

            SampleStatic.FirstVariable = "Static sample";

            SampleStatic.empNumber = 878787;
            SampleStatic.empNumber = 878787;
            SampleStatic.empNumber = 878787;
            SampleStatic.empNumber = 878787;
            SampleStatic.empNumber = 878787;
            SampleStatic.empNumber = 878787;
            SampleStatic.empNumber = 878787;

            FooStatic firstObj = new FooStatic();

            //Normal way of calling
            firstObj.FirstVariable = "Foo01";
            firstObj.SecondVariable = "Foo02";
            Console.WriteLine("FirstVariable = {0},SecondVariable = {1}, StaticVariable = {2}", firstObj.FirstVariable, firstObj.SecondVariable, FooStatic.StaticVariable);

            //Static way of calling property
            FooStatic.StaticVariable = "Static Data Changed";

            //Static way of calling Method
            FooStatic.StaticMethod();

            //Default Constructor will gets invoke if Constructor is not Specified in the class and assign the calss varaibles with thier default Values
            FooStatic thirdObj = new FooStatic();
            Console.WriteLine("FirstVariable = {0},SecondVariable = {1}, Institute = {2}", thirdObj.FirstVariable, thirdObj.SecondVariable, FooStatic.StaticVariable);

            Console.ReadKey();
        }
    }

    public class FooStatic
    {
        private string firstVariable;

        public string FirstVariable { get; set; }
        public string SecondVariable { get; set; }
        public static string StaticVariable { get; set; }

        public FooStatic()
        {
            FirstVariable = string.Empty;
            SecondVariable = string.Empty;
        }
        //Static Constructor
        static FooStatic()
        {
            StaticVariable = "Initial Static Data";
        }

        public static string StaticMethod()
        {
            return string.Format("I am a Static Method i need to be called using My Class Name");
        }

    }

    public static class SampleStatic
    {
        public static int empNumber = 0;
        public static string FirstVariable { get; set; }
        public static string SecondVariable { get; set; }
        public static string StaticVariable { get; set; }

        public static string StaticMethod()
        {
            return string.Format("I am a Static Method i need to be called using My Class Name");
        }
    }
}
