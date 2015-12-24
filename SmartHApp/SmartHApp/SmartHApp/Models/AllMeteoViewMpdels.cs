using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHApp.Models
{
    public class AllMeteoViewMpdels
    {
        public List<MeteoViewModel> Sensors
        {
            get;
            set;
        }

        public string AverageTemp
        {
            get;
            set;
        }

        public string AveragePress
        {
            get;
            set;
        }
    }
}