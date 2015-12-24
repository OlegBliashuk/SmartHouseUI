using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DataBaseInto.BaseWork;

using SmartHApp.Models;

namespace SmartHApp.Controllers
{
    public class StatisticController : BaseController
    {
        // GET: Statistic
        public ActionResult GetListLog()
        {
            var model = new List<LogViewModel>();
            var logfrombase = Service.GetAlLoggers();
            if (logfrombase.Count != 0)
            {
                foreach (var c in logfrombase)
                {
                    var newmod = new LogViewModel();
                    newmod.Time = c.Time.ToString("F");
                    newmod.Action = c.Action;
                    newmod.Result = c.Result;
                    model.Add(newmod);
                }


            }
            model.Reverse();
            return View(model);
        }
    }
}