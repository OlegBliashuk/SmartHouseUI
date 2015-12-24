using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartHApp.Controllers
{
    public class MeteoStationController : BaseController
    {
        // GET: MeteoStation
        public ActionResult OpenMain()
        {
            return View();
        }
    }
}