using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBaseInto.BaseWork;
using SmartHApp.Models;

namespace SmartHApp.Controllers
{
    public class ElectricityController : BaseController
    {
        // GET: Electricity
        public ActionResult OpenElectro()
        {
            var models = new List<ElectroViewModel>();
            var basedata = Service.GetAllElectric();
            if (basedata.Count() != 0)
            {
                foreach (var el in basedata)
                {
                    var model = new ElectroViewModel();
                    if (el.DispaysDevice != null) model.Displays = el.DispaysDevice.Value;
                    model.Id = el.Id;
                    model.Name = el.Name;
                    model.Status = el.Status;
                    model.Type = el.TypeDevice;
                    models.Add(model);
                }
            }
            return View(models);
        }

        public JsonResult SetMainLamp(string temper)
        {
            bool temp;
            bool.TryParse(temper, out temp);
            Service.ChangeMainLamp(temp);
            Service.LogAction(DateTime.Now, string.Format("Перемикачі ламп переведено в режим {0} ", temper), "Змінено");
            return Json("success");
        }
        public JsonResult SetMainToggle(string temper)
        {
            bool temp;
            bool.TryParse(temper, out temp);
            Service.ChangeMainToggle(temp);
            Service.LogAction(DateTime.Now, string.Format("Перемикачі переведено в режим {0} ", temper), "Змінено");
            return Json("success");
        }

        public JsonResult SetSensorToggle(string temper, string id)
        {
            bool temp;
            int idn;
            bool.TryParse(temper, out temp);
            int.TryParse(id, out idn);
            string name = Service.ChangeSensorToggle(temp, idn);
            Service.LogAction(DateTime.Now, string.Format("Перемикач \"{0}\" стан змінено на {1}", name, temper), "Змінено");
            return Json("success");
        }

        public JsonResult SetSensorLamp(string temper, string id)
        {
            bool temp;
            int idn;
            bool.TryParse(temper, out temp);
            int.TryParse(id, out idn);
            string name = Service.ChangeSensorToggle(temp, idn);
            Service.LogAction(DateTime.Now, string.Format("Лампа \"{0}\" стан змінено на {1}", name, temper), "Змінено");
            return Json("success");
        }
    }
}