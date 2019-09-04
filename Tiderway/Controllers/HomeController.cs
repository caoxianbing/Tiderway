using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tiderway.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult BanPai()
		{
			return View();
		}

		public ActionResult School()
		{
			return View();
		}

		public ActionResult Health()
		{
			return View();
		}
		public ActionResult SchoolHealth()
		{
			return View();
		}

		public ActionResult GNC()
		{
			return View();
		}
	}
}