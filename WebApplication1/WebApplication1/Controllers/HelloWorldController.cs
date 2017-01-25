using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Wellcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "ハロー " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }

        /*
                public string Index()
                {
                    return "Hello World・・・";

                }

        public string Wellcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("ここはweeeeeeelcome：ハロー " + name + "さん。 numTimes = " + numTimes);
        }
         */

        public string Login(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + "  ID:" + ID);
        }
    }
}