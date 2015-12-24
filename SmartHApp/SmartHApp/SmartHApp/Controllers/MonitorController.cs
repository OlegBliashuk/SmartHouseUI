using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DataBaseInto.BaseWork;

using SmartHApp.Models;

namespace SmartHApp.Controllers
{
    public class MonitorController : BaseController
    {
        // GET: Monitor
        public ActionResult GetState()
        {
            var model = new List<ErrorViewModel>();
            var logfrombase = Service.GetAlErrors();
            if (logfrombase.Count != 0)
            {
                foreach (var c in logfrombase)
                {
                    var newmod = new ErrorViewModel();
                    newmod.Time = c.Time.ToString("F");
                    newmod.Action = c.Message;
                    newmod.Result = c.State;
                    model.Add(newmod);
                }
            }
            model.Reverse();
            Service.LogAction(DateTime.Now, "Перегляд списку помилок", "Відображено");
            return View(model);
        }
    }
}