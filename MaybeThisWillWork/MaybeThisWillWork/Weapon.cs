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
        private string magazineSizes;
        private int rateOfFire;

        public Weapon(string type, string ammoType, int damage, int headDamage, int legDamage, string movementSpeedCut, string magazineSizes, int rateOfFire)
        {
            this.type = type;
            this.ammoType = ammoType;
            this.damage = damage;
            this.headDamage = headDamage;
            this.legDamage = legDamage;
            this.movementSpeedCut = movementSpeedCut;
            this.magazineSizes = magazineSizes;
            this.rateOfFire = rateOfFire;
        }

        public Weapon()
        {

        }

        public string ReturnValue()
        {
            StringBuilder builder = new StringBuilder("\n");
            builder.AppendLine("Weapon Type: " + type.ToString());
            builder.AppendLine("Used ammo: " + ammoType.ToString());
            builder.AppendLine("Damage: " + damage.ToString());
            builder.AppendLine("Headshot damange: " + headDamage.ToString());
            builder.AppendLine("Leg damage: " + legDamage.ToString());
            builder.AppendLine("Movement speed slowdown: " + movementSpeedCut.ToString());
            builder.AppendLine("Magazine sizes: " + magazineSizes.ToString());
            builder.AppendLine("Rate of fire [RPM]: " + rateOfFire.ToString());

            return builder.ToString();
        }
    }
}