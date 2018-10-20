using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreDemo_01.Models;
using System.Text.RegularExpressions;
using System.Text;

namespace DotNetCoreDemo_01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var i = 2;
            Func<int, int> f1 =(x) => x * i;
            i = 5;
            Func<int, int> f2 = x => f1(x);
            int xd = f2(2);
            xd = 33;

            //Predicate<int> p1 ()=>p>4;



            return View();




        }

        public void test(int? a=null,params int[] c)
        {

        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public  string StripOutAllHTMLTags(string input)
        {
            if (input == null) return input;

            char[] array = new char[input.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < input.Length; i++)
            {
                char let = input[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex).Replace("&#x18;", "'").Replace("&#x19;", "'");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
