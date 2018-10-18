﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetRPG.Runtime.Functions.Operation
{
    class Dsply : Function
    {
        public Dsply()
        {
            this._ParametersCount = 1;
        }

        public override object Execute(object[] Parameters)
        {
            string Result = (Parameters[0] as string);
            Console.WriteLine(Result);
            return null;
        }
    }
}
