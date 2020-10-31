using System;
using System.Text;

namespace MaybeThisWillWork
{
    public class Weapon
    {
        private string type;
        private string ammoType;
        private int damage;
        private int headDamage;
        private int legDamage;
        private string movementSpeedCut;
        private int magazineSize;
        private int rateOfFire;

        public Weapon(string type, string ammoType, int damage, int headDamage, int legDamage, string movementSpeedCut, int magazineSize, int rateOfFire)
        {
            this.type = type;
            this.ammoType = ammoType;
            this.damage = damage;
            this.headDamage = headDamage;
            this.legDamage = legDamage;
            this.movementSpeedCut = movementSpeedCut;
            this.magazineSize = magazineSize;
            this.rateOfFire = rateOfFire;
        }

        public Weapon()
        {

        }

        public string ReturnValue()
        {
            string toPad = " ";
            char padSign = ' ';
            ushort numberOfPads = 55;

            StringBuilder builder = new StringBuilder("\n");
            builder.AppendLine("Weapon Type: \n" + toPad.PadRight(numberOfPads, padSign) + type.ToString());
            builder.AppendLine("\nUsed ammo: \n" + toPad.PadRight(numberOfPads, padSign) + ammoType.ToString());
            builder.AppendLine("\nDamage: \n" + toPad.PadRight(numberOfPads, padSign) + damage.ToString());
            builder.AppendLine("\nHeadshot damange: \n" + toPad.PadRight(numberOfPads, padSign) + headDamage.ToString());
            builder.AppendLine("\nLeg damage: \n" + toPad.PadRight(numberOfPads, padSign) + legDamage.ToString());
            builder.AppendLine("\nMovement speed slowdown: \n" + toPad.PadRight(numberOfPads, padSign) + movementSpeedCut.ToString());
            builder.AppendLine("\nBase magazine size: \n" + toPad.PadRight(numberOfPads, padSign) + magazineSize.ToString());
            builder.AppendLine("\nRate of fire: \n" + toPad.PadRight(numberOfPads, padSign) + rateOfFire.ToString());

            return builder.ToString();
        }
    }
}
