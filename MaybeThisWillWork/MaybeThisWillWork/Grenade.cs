using System;
using System.Collections.Generic;
using System.Text;

namespace MaybeThisWillWork
{
    public class Grenade
    {
        private string property;
        private string damage;

        public Grenade(string property, string damage)
        {
            this.property = property;
            this.damage = damage;
        }

        public string [,] ReturnValues()
        {
            string[,] result = new string[2, 2];

            result[0, 0] = "";
            result[0, 1] = property;
            result[1, 0] = "Damage: ";
            result[1, 1] = damage;

            return result;
        }
    }
}
