using System;
using System.Collections.Generic;
using System.Text;

namespace MaybeThisWillWork
{
    public class Optics
    {
        private string description;
        private string compatibileWeapons;

        public Optics(string description, string compatibileWeapons)
        {
            this.description = description;
            this.compatibileWeapons = compatibileWeapons;
        }



        public string[,] ReturnProperty()
        {
            string[,] result = new string[2, 2];

            result[0, 0] = "";
            result[0, 1] = description;
            result[1, 0] = "Compatibile weapons: ";
            result[1, 1] = "";

            return result;
        }

        public List<string> ReturnCompatibileWeapons()
        {
            List<string> result = new List<string>(compatibileWeapons.Split(','));

            if (result[0] == "AllWeapons")
            {
                string hold = result[0];
                result = new List<string>();
                result.Add(hold);
                return result;
            }
            else
            {

                StringBuilder sb;
                for (int item = 0; item < result.Count; ++item)
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
}
