using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DataBaseInto.BaseWork;
using DataBaseInto.DBSet;
using SmartHApp.Models;
using WebGrease.Css.Extensions;

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

        public ActionResult Test()
        {
            var model = new TestModel();
            Stopwatch timer1 = new Stopwatch();
            timer1.Start();
            using (var context = new SmartHouseEntity())
            {
                for (int i = 1; i <= 1000; i++)
                {
                    var log = new Logger();
                    log.Time = DateTime.Now;
                    log.Action = $"test{i.ToString()}";
                    log.Result = "test";
                    context.Logger.Add(log);
                }
                context.SaveChanges();
            }
            timer1.Stop();
            var timesave = (timer1.ElapsedMilliseconds);
            model.TimetoSave = timesave.ToString();
            Stopwatch timer2 = new Stopwatch();
            timer2.Start();
            using (var context = new SmartHouseEntity())
            {
                for (int i = 1; i <= 1000; i++)
                {
                    var str = $"test{i.ToString()}";
                    var item = context.Logger.FirstOrDefault(x => x.Action == str);
                    context.Logger.Remove(item);
                }
                context.SaveChanges();
            }
            timer2.Stop();
            var timedelete = (timer2.ElapsedMilliseconds);
            model.TimeToDelete = timedelete.ToString();
            model.CountOfTests = 2000.ToString();
            return View(model);
        }
    }
}