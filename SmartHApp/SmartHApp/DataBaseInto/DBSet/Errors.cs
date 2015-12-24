using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseInto.DBSet
{
    public partial class Errors
    {
        public int id
        {
            get;
            set;
        }
        public DateTime Time
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
    }
}
