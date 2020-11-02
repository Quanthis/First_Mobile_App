using System;
using System.Collections.Generic;
using System.Text;

namespace MaybeThisWillWork
{
    public class KnockdownShield
    {
        private string shieldPoints;
        private string specialEffects = "none";

        public KnockdownShield(string shieldPoints)
        {
            this.shieldPoints = shieldPoints;
        }

        public KnockdownShield(string shieldPoints, string specialEffects)
        {
            this.shieldPoints = shieldPoints;
            this.specialEffects = specialEffects;
        }

        public string[,] ReturnValues()
        {
            if (specialEffects == "not set")
            {
                string[,] result = new string[1, 2];

                result[0, 0] = "Shield points: ";
                result[0, 1] = shieldPoints;

                return result;
            }
            else
            {
                string[,] result = new string[2, 2];

                result[0, 0] = "Shield points: ";
                result[0, 1] = shieldPoints;
                result[1, 0] = "Special Effects: ";
                result[1, 1] = specialEffects;

                return result;
            }
        }
    }
}