using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyCoreDemo.Controllers
{
    public class HelloController : Controller
    {
        
            
            // GET: /HelloWorld/

            public IActionResult Index()
            {
            return View();
            }

            // 
            // GET: /HelloWorld/Welcome/ 

            public string Welcome()
            {
                return "This is the Welcome action method...";
            }
        
    }
}