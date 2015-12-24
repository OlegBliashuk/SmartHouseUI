using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DataBaseInto.BaseWork;

using SmartHApp.Models;

namespace SmartHApp.Controllers
{
    public class MeteoStationController : BaseController
    {
        // GET: MeteoStation
        public ActionResult OpenMain()
        {
            var allmodel = new AllMeteoViewMpdels();
            allmodel.Sensors = new List<MeteoViewModel>();
            var getsensors = Service.GetAllMeteo();
            if (getsensors.Count != 0)
            {
                foreach (var sensor in getsensors)
                {
                    var sensormodel = new MeteoViewModel();
                    sensormodel.Id = sensor.Id;
                    sensormodel.Name = sensor.Name;
                    sensormodel.Type = sensor.TypeDevice;
                    if (sensor.DispaysDevice != null)
                    {
                        sensormodel.Displayes = sensor.DispaysDevice.Value;
                    }
                    allmodel.Sensors.Add(sensormodel);
                }
                var sumtemp = allmodel.Sensors.Where(x => x.Type == false).Sum(x => x.Displayes);
                allmodel.AverageTemp = (sumtemp / allmodel.Sensors.Count(x => x.Type == false)).ToString(CultureInfo.InvariantCulture);
                var sumpress = allmodel.Sensors.Where(x => x.Type == true).Sum(x => x.Displayes);
                allmodel.AveragePress = (sumpress / allmodel.Sensors.Count(x => x.Type == true)).ToString(CultureInfo.InvariantCulture);
            }
            return View(allmodel);
        }

        public JsonResult SetMainTemp(string temper)
        {
            double temp;
            double.TryParse(temper, out temp);
            Service.ChangeMaintemp(temp);
            Service.LogAction(DateTime.Now, string.Format("Середню температуру змінено на {0}",temper), "Змінено" );
            return Json("success");
        }

        public JsonResult SetMainPress(string temper)
        {
            double temp;
            double.TryParse(temper, out temp);
            Service.ChangeMainpress(temp);
            Service.LogAction(DateTime.Now, string.Format("Cередній тиск змінено на {0}", temper), "Змінено");
            return Json("success");
        }
        public JsonResult SetSensorTemp(string temper)
        {
            double temp;
            double.TryParse(temper, out temp);
            Service.ChangeMaintemp(temp);
            Service.LogAction(DateTime.Now, string.Format("Середню температуру змінено на {0}", temper), "Змінено");
            return Json("success");
        }

        public JsonResult SetSensorPress(string temper)
        {
            double temp;
            double.TryParse(temper, out temp);
            Service.ChangeMainpress(temp);
            Service.LogAction(DateTime.Now, string.Format("Cередній тиск змінено на {0}", temper), "Змінено");
            return Json("success");
        }

    }
}