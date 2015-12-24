using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DataBaseInto.BaseWork;
using DataBaseInto.DBSet;

namespace SmartHApp.Controllers
{
    public abstract class BaseController : Controller
    {
        protected SmartHouseEntity context;

        public BaseController()
        { 
            context = new SmartHouseEntity();
            context.Database.CreateIfNotExists();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }

    }
}