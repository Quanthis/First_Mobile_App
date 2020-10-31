using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using Xamarin.Forms;
using static System.Convert;


namespace MaybeThisWillWork
{
    public class ContentLoader
    {
        #region Weapons
        public enum Weapons
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

        Weapons weapon;

        public ContentLoader(Weapons weaponName)
        {
            weapon = weaponName;
        }

        public Label Fill()
        {
            Label result = new Label
            {
                Text = "",
                FontSize = 17,
                Margin = 3
            };

            string allWeaponsResourcePath = "MaybeThisWillWork.WeaponsData.";
            string fullPath;
            string weaponFile;
            Weapon dataToWrite;
            string dataReceiver;

            switch (weapon)
            {        
                case Weapons.R301:

                    weaponFile = "R301Data";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    dataToWrite = CreateWeaponFromData(fullPath);
                    dataReceiver = dataToWrite.ReturnValue();
                    result.Text = dataReceiver;

                    return result;
                    

                case Weapons.Flatline:

                    weaponFile = "FlatlineData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    dataToWrite = CreateWeaponFromData(fullPath);
                    dataReceiver = dataToWrite.ReturnValue();
                    result.Text = dataReceiver;

                    return result;                    

                default: return result;
            }
        }

        private Weapon CreateWeaponFromData(string weaponResourcePath)
        {
            ResourceManager resourceManager = new ResourceManager(weaponResourcePath, Assembly.GetExecutingAssembly());

            string type = resourceManager.GetString("Type");
            string ammoType = resourceManager.GetString("Ammo");
            int damage = ToInt32(resourceManager.GetString("Damage"));
            int headDamage = ToInt32(resourceManager.GetString("HeadDamage"));
            int legDamage = ToInt32(resourceManager.GetString("LegDamage"));
            string movementSpeedCut = resourceManager.GetString("MovementSpeedCut");
            int magazineSize = ToInt32(resourceManager.GetString("MagazineSize"));
            int rateOfFire = ToInt32(resourceManager.GetString("RateOfFire"));

            Weapon result = new Weapon(type, ammoType, damage, headDamage, legDamage, movementSpeedCut, magazineSize, rateOfFire);
            Debug.WriteLine(result.ReturnValue());

            return result;
        }

        #region archive
        private void CreateNewFile(string weaponDataFileName)
        {
            using (FileStream fs = new FileStream(weaponDataFileName, FileMode.Create))
            {
                lock (fs)
                {
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        writer.WriteLine("\nAssault Rifle");
                        writer.WriteLine("Light");
                        writer.WriteLine(14);
                        writer.WriteLine(28);
                        writer.WriteLine(11);
                        writer.WriteLine("10%");
                        writer.WriteLine(18);
                        writer.WriteLine(816);

                        writer.Flush();
                    }
                }
            }
        }
        #endregion
    }
}
