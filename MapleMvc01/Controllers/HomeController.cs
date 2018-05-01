using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MapleMvc01.Models;
namespace MapleMvc01.Controllers
{
    public class HomeController : Controller
    {
        MapleContext context = new MapleContext();

        public ActionResult Index()
        {
            var person = context.Persons.ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}