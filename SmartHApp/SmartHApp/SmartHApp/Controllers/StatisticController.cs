using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartHApp.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        public ActionResult GetListLog()
        {
            return View();
        }
    }
}