using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Topic("help");
            t.MethodA();

            var p = new Product("git");
            p.MethodA();
        }
    }
}
