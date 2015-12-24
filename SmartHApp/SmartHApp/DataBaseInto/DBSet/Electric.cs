using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseInto.DBSet
{
    public partial class Electric
    {
        public Electric()
        {
            this.ElectricStates = new HashSet<ElectricState>();
        }
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public Nullable<Double> DispaysDevice
        {
            get;
            set;
        }

        public bool TypeDevice
        {
            get;
            set;
        }

        public bool Status
        {
            get;
            set;
        }
        public virtual ICollection<ElectricState> ElectricStates { get; set; }
    }
}
