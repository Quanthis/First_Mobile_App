using System;
using System.Collections.Generic;
using System.Text;

namespace MaybeThisWillWork
{
    public class Character
    {
        private string tactical;
        private string ultimate;
        private string damageReceived;
        private string additional = "none";
        private string passive;

        public Character(string tactical, string ultimate, string damageReceived, string passive)
        {
            this.tactical = tactical;
            this.ultimate = ultimate;
            this.damageReceived = damageReceived;
            this.passive = passive;
        }

        public Character(string tactical, string ultimate, string damageReceived, string passive, string additional)
        {
            this.tactical = tactical;
            this.ultimate = ultimate;
            this.damageReceived = damageReceived;
            this.passive = passive;
            this.additional = additional;
        }

        public string[,] ReturnValues()
        {
            if (additional == "none")
            {
                string[,] result = new string[4, 2];

                result[0, 0] = "\nTactical ability: ";
                result[0, 1] = tactical;
                result[1, 0] = "\nUltimate ability: ";
                result[1, 1] = ultimate;
                result[2, 0] = "\nPassive ability: ";
                result[2, 1] = passive;
                result[3, 0] = "\nDamage received: ";
                result[3, 1] = damageReceived;

                return result;
            }
            else
            {
                string[,] result = new string[5, 2];

                result[0, 0] = "\nTactical ability: ";
                result[0, 1] = tactical;
                result[1, 0] = "\nUltimate ability: ";
                result[1, 1] = ultimate;
                result[2, 0] = "\nPassive ability: ";
                result[2, 1] = passive;
                result[3, 0] = "\nDamage received: ";
                result[3, 1] = damageReceived;
                result[4, 0] = "\nAdditional features: ";
                result[4, 1] = additional;

                return result;
            }
        }
    }
}
