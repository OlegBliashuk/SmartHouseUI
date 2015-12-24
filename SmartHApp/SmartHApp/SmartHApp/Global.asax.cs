using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using DataBaseInto.BaseWork;
using DataBaseInto.DBSet;

namespace SmartHApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_End(Object sender, EventArgs e)
        {
            using (var context = new SmartHouseEntity())
            {
                context.Database.CreateIfNotExists();
                Service.LogAction(DateTime.Now, "Сесію завершено", "Все добре!");
            }
        }

        protected void Session_Start(Object sender, EventArgs e)
        {
            using (var context = new SmartHouseEntity())
            {
                context.Database.CreateIfNotExists();
                Service.LogAction(DateTime.Now, "Розпочато роботу", "Все добре!");
            }
        }
    }
}
