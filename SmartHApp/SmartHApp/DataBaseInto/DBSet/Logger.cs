using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseInto.DBSet
{
    public partial class Logger
    {
        public int Id
        {
            get;
            set;
        }

        public DateTime Time
        {
            get;
            set;
        }

        public string Action
        {
            get;
            set;
        }

        public string Result
        {
            get;
            set;
        }
    }
}
