using System;
using System.Collections.Generic;
using System.Text;

namespace MaybeThisWillWork
{
    public class Backpack
    {
        private string additionalSlots;
        private string specialEffects = "none";

        public Backpack(string additionalSlots)
        {
            this.additionalSlots = additionalSlots;
        }

        public Backpack(string additionalSlots, string specialEffects)
        {
            this.additionalSlots = additionalSlots;
            this.specialEffects = specialEffects;
        }

        public string[,] ReturnValues()
        {
            if (specialEffects == "not set")
            {
                string[,] result = new string[1, 2];

                result[0, 0] = "Additional slots in equipment: ";
                result[0, 1] = additionalSlots;

                return result;
            }
            else
            {
                string[,] result = new string[2, 2];

                result[0, 0] = "Additional slots in equipment: ";
                result[0, 1] = additionalSlots;
                result[1, 0] = "Special Effects: ";
                result[1, 1] = specialEffects;

                return result;
            }
        }
    }
}
