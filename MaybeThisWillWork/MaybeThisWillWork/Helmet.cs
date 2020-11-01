using System;

namespace MaybeThisWillWork
{
    public class Helmet
    {
        private string headshotDamageReduction;
        private string specialEffects;

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
            if (specialEffects != null)
            {
                string[,] result = new string[2, 2];

                result[0, 0] = "Headshot damage reduction: ";
                result[0, 1] = headshotDamageReduction;
                result[1, 0] = "Special Effects: ";
                result[1, 1] = specialEffects;

                return result;
            }
            else
            {
                string[,] result = new string[1, 1];

                result[0, 0] = "Headshot damage reduction: ";
                result[0, 1] = headshotDamageReduction;

                return result;
            }
        }
    }
}
