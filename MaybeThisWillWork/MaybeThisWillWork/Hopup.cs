using System;
using System.Collections.Generic;

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

        public string[,] ReturnProperty()
        {
            string[,] result = new string[2, 2];

            result[0, 0] = "";
            result[0, 1] = property;
            result[1, 0] = "Compatibile weapons: ";
            result[1, 1] = "";

            return result;
        }

        public List<string> ReturnCompatibileWeapons()
        {
            List<string> result = new List<string>(compatibileWeapons.Split(','));

            return result;
        }
    }
}
