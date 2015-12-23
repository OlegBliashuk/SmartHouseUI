using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartHApp.Controllers
{
    public class ElectricityController : Controller
    {
        // GET: Electricity
        public ActionResult OpenElectro()
        {
            return View();
        }
    }
}