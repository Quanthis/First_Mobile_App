using System;

namespace MaybeThisWillWork
{
    public class Helmet
    {
        private string headshotDamageReduction;
        private string specialEffects = "not set";

        public Helmet(string headshotDamageReduction)
        {
            this.headshotDamageReduction = headshotDamageReduction;
        }

        public Helmet(string headshotDamageReduction, string specialEffects)
        {
            this.headshotDamageReduction = headshotDamageReduction;
            this.specialEffects = specialEffects;
        }

        public string[,] ReturnValues()
        {
            if (specialEffects == "not set")
            {
                string[,] result = new string[1, 2];

                result[0, 0] = "Headshot damage reduction: ";
                result[0, 1] = headshotDamageReduction;

                return result;
            }
            else
            {
                string[,] result = new string[2, 2];

                result[0, 0] = "Headshot damage reduction: ";
                result[0, 1] = headshotDamageReduction;
                result[1, 0] = "Special Effects: ";
                result[1, 1] = specialEffects;

                return result;
            }
        }
    }
}
