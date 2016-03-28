using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloGit.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            Response.Write("<h1>Hello GitHub</>");
        }

        public void Foobar()
        {
            Response.Write("<h1>From foobar</h1>");
        }
    }
}
