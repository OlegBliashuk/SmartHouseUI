using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataBaseInto.DBSet;

namespace DataBaseInto.BaseWork
{
    public class Service 
    {
        public static void LogAction(DateTime time, string action, string result)
        {
            using (var context = new SmartHouseEntity())
            {
                var log = new Logger();
                log.Time = time;
                log.Action = action;
                log.Result = result;
                context.Logger.Add(log);
                context.SaveChanges();
            }
        }

        public static List<Logger> GetAlLoggers()
        {
            List<Logger> logs = new List<Logger>();
            using (var context = new SmartHouseEntity())
            {
                var logsall = context.Logger.ToList();
                if (logsall.Count != 0)
                {
                    foreach (var c in logsall)
                    {
                        logs.Add(c);
                    }
                }
            }
            return logs;
        }

        public static List<Errors> GetAlErrors()
        {
            List<Errors> logs = new List<Errors>();
            using (var context = new SmartHouseEntity())
            {
                var logsall = context.Errors.ToList();
                if (logsall.Count != 0)
                {
                    foreach (var c in logsall)
                    {
                        logs.Add(c);
                    }
                }
            }
            return logs;
        }

        public static void ChangeMaintemp(double temp) {
            using (var context = new SmartHouseEntity())
            {
                foreach (var sensor in context.Meteo.Where(x=>x.TypeDevice ==false))
                {
                    sensor.DispaysDevice = temp;
                }
                context.SaveChanges();
            }
        }

        public static void ChangeMainpress(double temp)
        {
            using (var context = new SmartHouseEntity())
            {
                foreach (var sensor in context.Meteo.Where(x => x.TypeDevice == true))
                {
                    sensor.DispaysDevice = temp;
                }
                context.SaveChanges();
            }
        }

        public static List<Meteo> GetAllMeteo()
        {
            List<Meteo> logs = new List<Meteo>();
            using (var context = new SmartHouseEntity())
            {
                var logsall = context.Meteo.ToList();
                if (logsall.Count != 0)
                {
                    foreach (var c in logsall)
                    {
                        logs.Add(c);
                    }
                }
            }
            return logs;
        }
    }
}
