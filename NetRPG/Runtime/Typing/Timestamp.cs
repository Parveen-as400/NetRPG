using System;
using System.Collections.Generic;
using System.Text;
using NetRPG.Language;

namespace NetRPG.Runtime.Typing
{
    class Timestamp : DataValue
    {
        public Timestamp(string name, int initialValue = 0)
        {
            this.Name = name;

            this.InitValue = initialValue;

            this.Dimentions = 1;
            this.Value = new object[this.Dimentions];

            this.DoInitialValue();
        }

        public override void Set(object value, int index = 0)
        {
            this.Value[index] = Convert.ToInt32(value);
        }
    }
}
