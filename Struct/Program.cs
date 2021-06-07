using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            InOutSample obj = new InOutSample();
            obj.email = "testing@gmail";
            obj.id = 2323;
        }
    }
    public struct InOutSample
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
}
