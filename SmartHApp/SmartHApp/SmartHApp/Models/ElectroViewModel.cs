using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHApp.Models
{
    public class ElectroViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Displays { get; set; }
        public bool Type { get; set; }
        public bool Status { get; set; }
    }
}