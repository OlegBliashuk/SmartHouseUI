using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataBaseInto.DBSet;

namespace DataBaseInto.BaseWork
{
    public class Service : IService
    {
        public bool LogAction(DateTime time, string action, string result)
        {
            bool state = false;
            using (var context = new SmartHouseEntity() )
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
    }
}
