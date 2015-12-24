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
        public static bool LogAction(DateTime time, string action, string result)
        {
            bool state = false;
            using (var context = new SmartHouseEntity())
            {
                var log = new Logger();
                log.Time = time;
                log.Action = action;
                log.Result = result;
                context.Logger.Add(log);
                state = true;
                context.SaveChanges();
            }
            return state;
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
                        logs.Add(c);
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
                        logs.Add(c);
                }
            }
            return logs;
        }
    }
}
