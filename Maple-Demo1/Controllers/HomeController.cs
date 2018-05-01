using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.CodeDom;

namespace Maple_Demo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            ViewBag.strWCF = client.GetMsg();


            MyDemoService1.MyDemoServiceSoapClient bb = new MyDemoService1.MyDemoServiceSoapClient();

            var ddd = bb.GetWebServiceMsg();



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