using System;
using System.Collections.Generic;
using System.Text;

namespace MaybeThisWillWork
{
    public class Armor
    {
        private string armorPoints;
        private string specialEffects = "none";
        private string damageNeededToEvolve = "0";

        public Armor(string armorPoints)
        {
            this.armorPoints = armorPoints;
        }

        public Armor(string armorPoints, string specialEffects)
        {
            this.armorPoints = armorPoints;
            this.specialEffects = specialEffects;
        }

        public Armor(string armorPoints, string specialEffects, string damageNeededToEvolve) : this(armorPoints, specialEffects)
        {
            this.damageNeededToEvolve = damageNeededToEvolve;
        }

        public string[,] ReturnValues()
        {
            if (specialEffects == "not set")
            {
                if (damageNeededToEvolve == "0")
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
                    result[1, 0] = "Damage needed to evolve: ";
                    result[1, 1] = damageNeededToEvolve;

                    return result;
                }
            }
            else
            {
                if (damageNeededToEvolve == "0")
                {
                    string[,] result = new string[2, 2];

                    result[0, 0] = "Armor health points: ";
                    result[0, 1] = armorPoints;
                    result[1, 0] = "Special Effects: ";
                    result[1, 1] = specialEffects;

                    return result;
                }
                else
                {
                    string[,] result = new string[3, 2];

                    result[0, 0] = "Armor health points: ";
                    result[0, 1] = armorPoints;
                    result[1, 0] = "Special Effects: ";
                    result[1, 1] = specialEffects;
                    result[2, 0] = "Damage needed to evolve: ";
                    result[2, 1] = damageNeededToEvolve;

                    return result;
                }
            }
        }
    }
}