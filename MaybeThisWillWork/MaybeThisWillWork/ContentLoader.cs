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
            Volt,

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
            Hemlok,
            Wingman,

            Longbow,
            TripleTake,
            ChargeRifle,
            Sentinel
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
                Margin = 3,
                LineHeight = 2,
                TextColor = Xamarin.Forms.Color.White
            };

            string allWeaponsResourcePath = "MaybeThisWillWork.WeaponsData.";
            string fullPath;
            string weaponFile;

            switch (weapon)
            {        
                case Weapons.R301:

                    weaponFile = "R301Data";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;
                    

                case Weapons.Flatline:

                    weaponFile = "FlatlineData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Alternator:

                    weaponFile = "AlternatorData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                

                case Weapons.ChargeRifle:

                    weaponFile = "ChargeRifleData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Devotion:

                    weaponFile = "DevotionData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Eva8:

                    weaponFile = "Eva8AutoData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.G7Scout:

                    weaponFile = "G7ScoutData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Havoc:

                    weaponFile = "HavocData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Hemlok:

                    weaponFile = "HemlokData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Kraber:

                    weaponFile = "KraberData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Longbow:

                    weaponFile = "LongbowData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.LSTAR:

                    weaponFile = "LstarData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Mastiff:

                    weaponFile = "MastiffData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Mozambique:

                    weaponFile = "MozambiqueData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.P2020:

                    weaponFile = "P2020Data";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Peacekeeper:

                    weaponFile = "PeacekeeperData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;


                case Weapons.Prowler:

                    weaponFile = "ProwlerData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.R99:

                    weaponFile = "R99Data";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Re45:

                    weaponFile = "Re45Data";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Sentinel:

                    weaponFile = "SentinelData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Spitfire:

                    weaponFile = "SpitfireData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.TripleTake:

                    weaponFile = "TripleTakeData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Volt:

                    weaponFile = "VoltData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                case Weapons.Wingman:

                    weaponFile = "WingmanData";
                    fullPath = allWeaponsResourcePath + weaponFile;

                    result.Text = DoCasesWork(fullPath);

                    return result;

                default: return result;
            }
        }

        private string DoCasesWork(string fullPath)
        {
            Weapon dataToWrite = CreateWeaponFromData(fullPath);
            string dataReceiver = dataToWrite.ReturnValue();
            return dataReceiver;
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
