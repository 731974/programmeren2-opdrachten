﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class ErrorRetrievingAccountFromSave : Exception
    {
        public ErrorRetrievingAccountFromSave(string message) : base(message) { }
    }
}
