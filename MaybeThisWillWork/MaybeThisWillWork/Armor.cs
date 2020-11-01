using System;
using System.Collections.Generic;
using System.Text;

namespace MaybeThisWillWork
{
    public class Armor
    {
        private string armorPoints;
        private string specialEffects = "none";

        public Armor(string armorPoints)
        {
            this.armorPoints = armorPoints;
        }

        public Armor(string armorPoints, string specialEffects)
        {
            this.armorPoints = armorPoints;
            this.specialEffects = specialEffects;
        }

        public string[,] ReturnValues()
        {
            if (specialEffects == "not set")
            {
                string[,] result = new string[1, 2];

                result[0, 0] = "Armor health points: ";
                result[0, 1] = armorPoints;

                return result;
            }
            else
            {
                string[,] result = new string[2, 2];

                result[0, 0] = "Armor health points: ";
                result[0, 1] = armorPoints;
                result[1, 0] = "Special Effects: ";
                result[1, 1] = specialEffects;

                return result;
            }
        }
    }
}
