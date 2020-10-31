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
            ushort numberOfPads = 40;

            StringBuilder builder = new StringBuilder("\n");
            builder.AppendLine("Weapon Type: " + type.ToString());
            builder.AppendLine("Used ammo: " + ammoType.ToString());
            builder.AppendLine("Damage: " + damage.ToString());
            builder.AppendLine("Headshot damange: " + headDamage.ToString());
            builder.AppendLine("Leg damage: " + legDamage.ToString());
            builder.AppendLine("Movement speed slowdown: " + movementSpeedCut.ToString());
            builder.AppendLine("Base magazine size: " + magazineSize.ToString());
            builder.AppendLine("Rate of fire: " + rateOfFire.ToString());

            return builder.ToString();
        }
    }
}
