using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    class Program
    {
        static void Main(string[] args)
        {
            DashBoard dash = new DashBoard();
            dash.AddNumber();
            dash.Subtract();
            dash.Multiplication();
            dash.Division();
        }
    }

    public partial class DashBoard
    {
        public int AddNumber()
        {
            return 56 + 78;
        }
    }

    public partial class DashBoard
    {
        public int Subtract()
        {
            return 56 + 78;
        }
    }
    public partial class DashBoard
    {
        public int Multiplication()
        {
            return 56 * 78;
        }
    }
    public partial class DashBoard
    {
        public int Division()
        {
            return 56 / 78;
        }
    }

}