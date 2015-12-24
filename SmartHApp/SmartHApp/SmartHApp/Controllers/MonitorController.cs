using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartHApp.Controllers
{
    public class MonitorController : BaseController
    {
        // GET: Monitor
        public ActionResult GetState()
        {
            return View();
        }
    }
}