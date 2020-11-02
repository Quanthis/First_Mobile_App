using System;
using System.Collections.Generic;
using System.Text;

namespace MaybeThisWillWork
{
    public class Hopup
    {
        private string property;
        private string compatibileWeapons;

        public Hopup(string property, string compatibileWeapons)
        {
            this.property = property;
            this.compatibileWeapons = compatibileWeapons;
        }

        public string[,] ReturnValues()
        {
            string[,] result = new string[2, 2];

            result[0, 0] = "";
            result[0, 1] = property;
            result[1, 0] = "Compatibile weapons: ";
            result[1, 1] = compatibileWeapons;

            return result;
        }
    }
}
