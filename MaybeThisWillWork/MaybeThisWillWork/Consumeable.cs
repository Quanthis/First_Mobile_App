using System;
using System.Collections.Generic;

namespace MaybeThisWillWork
{
    public class Consumeable
    {
        private string property;
        private string usageTime;

        public Consumeable(string property, string usageTime)
        {
            this.property = property;
            this.usageTime = usageTime;
        }

        public string[] ReturnValues()
        {
            string[] result = { property, usageTime };
            return result;
        }
    }
}
