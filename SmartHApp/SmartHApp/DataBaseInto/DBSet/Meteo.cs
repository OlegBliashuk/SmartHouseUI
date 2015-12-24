using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseInto.DBSet
{
    public partial class Meteo
    {
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

        public Nullable<double> DispaysDevice
        {
            get;
            set;
        }

        public bool TypeDevice
        {
            get;
            set;
        }
    }
}
