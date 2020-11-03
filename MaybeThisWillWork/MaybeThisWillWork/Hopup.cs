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

            StringBuilder sb;
            for (int item = 0 ; item < result.Count; ++item)
            {
                sb = new StringBuilder(result[item]);
                if (result[item].Contains(" "))
                {
                    int index = result[item].IndexOf(" ");
                    sb.Remove(index, 1);
                    result[item] = sb.ToString();
                }
            }

            return result;
        }
    }
}
