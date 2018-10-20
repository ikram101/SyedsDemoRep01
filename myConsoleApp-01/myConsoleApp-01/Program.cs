using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myConsoleApp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var xx = new { Id=3,Name="SYED",City="ISD"  };

            var myAnonymousType = new
            {
                firstProperty = "First Property",
                secondProperty = 2,
                thirdProperty = true
            };

            DoSomethig(myAnonymousType);

            Console.ReadKey();
        }


        static void DoSomethig(dynamic param)
        {
            Console.WriteLine(param.firstProperty);
        }
    }
}
