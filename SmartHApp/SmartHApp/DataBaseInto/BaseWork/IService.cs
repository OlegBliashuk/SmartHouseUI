﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseInto.BaseWork
{
    public interface IService
    {
        bool LogAction(DateTime time, string action, string result);
    }
}
