using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using A2MVC4.Models;

namespace A2MVC4.Controllers
{
    public class ArithController : Controller
    {
        //
        // GET: /Arith/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Arith/Arith?n=3&m=4

        public ActionResult Arith(int n = 4, int m = 3)
        {
            // ArithClass is defined as a Model (see this)
            var S = new ArithClass { N = n, M = m };
            return View(S);
        }


    }
}
