﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SecurityService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SecurityService" in both code and config file together.
    public class SecurityService : ISecurityService
    {
        public string DoWork(string message)
        {
            return "Hello " + message;
        }
    }
}
