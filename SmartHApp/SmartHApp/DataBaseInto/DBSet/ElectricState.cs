using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseInto.DBSet
{
    public partial class ElectricState
    {
        public int Id
        {
            get;
            set;
        }
        public DateTime StartDate
        {
            get;
            set;
        }
        public double Summary
        {
            get;
            set;
        }
        public int DevicElectric_Id
        {
            get;
            set;
        }

        public virtual Electric Electric { get; set; }

    }
}
