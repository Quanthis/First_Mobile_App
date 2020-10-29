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
            StringBuilder builder = new StringBuilder("\n");
            builder.AppendLine(type.ToString());
            builder.AppendLine(ammoType.ToString());
            builder.AppendLine(damage.ToString());
            builder.AppendLine(headDamage.ToString());
            builder.AppendLine(legDamage.ToString());
            builder.AppendLine(movementSpeedCut.ToString());
            builder.AppendLine(magazineSize.ToString());
            builder.AppendLine(rateOfFire.ToString());

            return builder.ToString();
        }
    }
}
