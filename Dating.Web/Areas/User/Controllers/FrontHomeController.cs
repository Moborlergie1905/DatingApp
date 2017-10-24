using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dating.Web.Areas.User.Controllers
{
    public class FrontHomeController : Controller
    {
        // GET: User/FrontHome
        public ActionResult Index()
        {
            return View();
        }
    }
}