using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MaybeThisWillWork
{
    public class ContentLoader
    {
        #region Weapons
        public enum Weapon
        {
            LSTAR,
            Devotion,
            Havoc,

            Mastiff,
            Eva8,
            Mozambique,

            Kraber,
            R99,
            Peacekeeper,

            R301,
            G7Scout,
            Alternator,
            Re45,
            P2020,

            Prowler,
            Flatline,
            Spitfire,
            Hemlok
        };
        #endregion

        Weapon weapon;

        public ContentLoader(Weapon weaponName)
        {
            weapon = weaponName;
        }

        public Label Fill()
        {
            Label result = new Label
            {
                Text = ""
            };

            StringBuilder builder = new StringBuilder("");

            switch (weapon)
            {        
                case Weapon.R301:
                    builder.AppendLine("Type: Assault Rifle");          //this is a temporary way of adding data, may change it in future
                    builder.AppendLine("Damage: 14");

                    result.Text = builder.ToString();
                    return result;

                default: return result;
            }
        }
    }
}
