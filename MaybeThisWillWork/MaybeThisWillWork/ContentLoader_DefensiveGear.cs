﻿using System;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;

namespace MaybeThisWillWork
{
    public class ContentLoader_DefensiveGear
    {
        public enum DefensiveGears
        {
            Helmet,
            Armor,
            KnockdownShield,
            Backpack
        };

        public enum GearLevels
        {
            Lv1,
            Lv2,
            Lv3,
            Lv4,
            Lv5
        };

        private DefensiveGears gearType;
        private GearLevels gearLevel;

        public ContentLoader_DefensiveGear(DefensiveGears type, GearLevels gearLevel)
        {
            gearType = type;
            this.gearLevel = gearLevel;
        }

        public StackLayout Fill(StackLayout result)
        {
            result.Margin = 20;

            string allDefensiveGearsResourcePath = "MaybeThisWillWork.DefensiveGear_Data.";
            string fullPath;

            switch (gearType)
            {
                case DefensiveGears.Helmet:

                    switch(gearLevel)
                    {
                        case GearLevels.Lv1:

                            fullPath = allDefensiveGearsResourcePath + "HelmetLv1";

                            result = FillHelmets(false, fullPath, result);                            

                            return result;

                        case GearLevels.Lv2:

                            fullPath = allDefensiveGearsResourcePath + "HelmetLv2";

                            result = FillHelmets(false, fullPath, result);

                            return result;

                        case GearLevels.Lv3:

                            fullPath = allDefensiveGearsResourcePath + "HelmetLv3";

                            result = FillHelmets(false, fullPath, result);

                            return result;

                        case GearLevels.Lv4:

                            fullPath = allDefensiveGearsResourcePath + "HelmetLv4";

                            result = FillHelmets(true, fullPath, result);

                            return result;
                    }
                    break;

                case DefensiveGears.Armor:

                    switch(gearLevel)
                    {
                        case GearLevels.Lv1:

                            fullPath = allDefensiveGearsResourcePath + "ArmorLv1";

                            result = FillArmors(false, true, fullPath, result);

                            return result;

                        case GearLevels.Lv2:

                            fullPath = allDefensiveGearsResourcePath + "ArmorLv2";

                            result = FillArmors(false, true, fullPath, result);

                            return result;

                        case GearLevels.Lv3:

                            fullPath = allDefensiveGearsResourcePath + "ArmorLv3";

                            result = FillArmors(false, true, fullPath, result);

                            return result;

                        case GearLevels.Lv4:

                            fullPath = allDefensiveGearsResourcePath + "ArmorLv4";

                            result = FillArmors(true, fullPath, result);

                            return result;

                        case GearLevels.Lv5:

                            fullPath = allDefensiveGearsResourcePath + "ArmorLv5";

                            result = FillArmors(false, fullPath, result);

                            return result;
                    }
                    break;

                case DefensiveGears.KnockdownShield:
                    
                    switch(gearLevel)
                    {
                        case GearLevels.Lv1:

                            fullPath = allDefensiveGearsResourcePath + "KnockdownShieldLv1";

                            result = FillKnockdownShields(false, fullPath, result);

                            return result;

                        case GearLevels.Lv2:

                            fullPath = allDefensiveGearsResourcePath + "KnockdownShieldLv2";

                            result = FillKnockdownShields(false, fullPath, result);

                            return result;

                        case GearLevels.Lv3:

                            fullPath = allDefensiveGearsResourcePath + "KnockdownShieldLv3";

                            result = FillKnockdownShields(false, fullPath, result);

                            return result;

                        case GearLevels.Lv4:

                            fullPath = allDefensiveGearsResourcePath + "KnockdownShieldLv4";

                            result = FillKnockdownShields(true, fullPath, result);

                            return result;
                    }
                    break;

                case DefensiveGears.Backpack:

                    switch(gearLevel)
                    {
                        case GearLevels.Lv1:

                            fullPath = allDefensiveGearsResourcePath + "BackpackLv1";

                            result = FillBackpacks(false, fullPath, result);

                            return result;

                        case GearLevels.Lv2:

                            fullPath = allDefensiveGearsResourcePath + "BackpackLv2";

                            result = FillBackpacks(false, fullPath, result);

                            return result;

                        case GearLevels.Lv3:

                            fullPath = allDefensiveGearsResourcePath + "BackpackLv3";

                            result = FillBackpacks(false, fullPath, result);

                            return result;

                        case GearLevels.Lv4:

                            fullPath = allDefensiveGearsResourcePath + "BackpackLv4";

                            result = FillBackpacks(true, fullPath, result);

                            return result;
                    }
                    break;



                default:

                    var usualProperty = new Label
                    {
                        Text = "Sorry, an error has occured",
                    };

                    result.Children.Add(usualProperty);

                    return result;
            }

            var usualProperty2 = new Label
            {
                Text = "Sorry, an error has occured",
            };

            result.Children.Add(usualProperty2);

            return result;
        }

        #region FillingMethods
        private StackLayout FillBackpacks(bool hasSpecialEffects, string fullResourcePath, StackLayout result)
        {
            Label usualPropertyTitle;
            Label usualProperty;
            Label specialEffect;
            Label specialEffectTitle;

            if (!hasSpecialEffects)
            {
                usualPropertyTitle = new Label
                {
                    Text = CreateBackpackFromData(fullResourcePath).ReturnValues()[0, 0]
                };
                result.Children.Add(SetLabelProperties(usualPropertyTitle));

                usualProperty = new Label
                {
                    Text = CreateBackpackFromData(fullResourcePath).ReturnValues()[0, 1]
                };
                result.Children.Add(SetLabelProperties(usualProperty));

                return result;
            }

            else
            {
                usualPropertyTitle = new Label
                {
                    Text = CreateBackpackFromData(fullResourcePath).ReturnValues()[0, 0]
                };
                result.Children.Add(SetLabelProperties(usualPropertyTitle));

                usualProperty = new Label
                {
                    Text = CreateBackpackFromData(fullResourcePath).ReturnValues()[0, 1]
                };
                result.Children.Add(SetLabelProperties(usualProperty));

                specialEffectTitle = new Label
                {
                    Text = CreateBackpackFromData(fullResourcePath).ReturnValues()[1, 0]
                };
                result.Children.Add(SetLabelProperties(specialEffectTitle));

                specialEffect = new Label
                {
                    Text = CreateBackpackFromData(fullResourcePath).ReturnValues()[1, 1]
                };
                result.Children.Add(SetLabelProperties(specialEffect));

                return result;
            }
        }

        private StackLayout FillKnockdownShields(bool hasSpecialEffects, string fullResourcePath, StackLayout result)
        {
            Label usualPropertyTitle;
            Label usualProperty;
            Label specialEffect;
            Label specialEffectTitle;

            if(!hasSpecialEffects)
            {
                usualPropertyTitle = new Label
                {
                    Text = CreateKnockdownShieldFromData(fullResourcePath).ReturnValues()[0, 0]
                };
                result.Children.Add(SetLabelProperties(usualPropertyTitle));

                usualProperty = new Label
                {
                    Text = CreateKnockdownShieldFromData(fullResourcePath).ReturnValues()[0, 1]
                };
                result.Children.Add(SetLabelProperties(usualProperty));

                return result;
            }
            else
            {
                usualPropertyTitle = new Label
                {
                    Text = CreateKnockdownShieldFromData(fullResourcePath).ReturnValues()[0, 0]
                };
                result.Children.Add(SetLabelProperties(usualPropertyTitle));

                usualProperty = new Label
                {
                    Text = CreateKnockdownShieldFromData(fullResourcePath).ReturnValues()[0, 1]
                };
                result.Children.Add(SetLabelProperties(usualProperty));

                specialEffectTitle = new Label
                {
                    Text = CreateKnockdownShieldFromData(fullResourcePath).ReturnValues()[1, 0]
                };
                result.Children.Add(SetLabelProperties(specialEffectTitle));

                specialEffect = new Label
                {
                    Text = CreateKnockdownShieldFromData(fullResourcePath).ReturnValues()[1, 1]
                };
                result.Children.Add(SetLabelProperties(specialEffect));

                return result;
            }
        }

        private StackLayout FillArmors(bool hasSpecialEffects, bool canEvolve, string fullResourcePath, StackLayout result)
        {
            Label usualPropertyTitle;
            Label usualProperty;
            Label specialEffect;
            Label specialEffectTitle;
            Label toEvolve;
            Label toEvolveTitle;

            if (!hasSpecialEffects)
            {
                usualPropertyTitle = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[0, 0]
                };
                result.Children.Add(SetLabelProperties(usualPropertyTitle));

                usualProperty = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[0, 1]
                };
                result.Children.Add(SetLabelProperties(usualProperty));
            }
            else
            {
                usualPropertyTitle = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[0, 0]
                };
                result.Children.Add(SetLabelProperties(usualPropertyTitle));

                usualProperty = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[0, 1]
                };
                result.Children.Add(SetLabelProperties(usualProperty));

                specialEffectTitle = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[1, 0]
                };
                result.Children.Add(SetLabelProperties(specialEffectTitle));

                specialEffect = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[1, 1]
                };
                result.Children.Add(SetLabelProperties(specialEffect));
            }

            if(canEvolve)
            {
                toEvolveTitle = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[2, 0]
                };
                result.Children.Add(SetLabelProperties(toEvolveTitle));

                toEvolve = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[2, 1]
                };
                result.Children.Add(SetLabelProperties(toEvolve));
            }

            return result;
        }

        private StackLayout FillArmors(bool hasSpecialEffects, string fullResourcePath, StackLayout result)
        {
            Label usualPropertyTitle;
            Label usualProperty;
            Label specialEffect;
            Label specialEffectTitle;

            if(!hasSpecialEffects)
            {
                usualPropertyTitle = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[0, 0]
                };
                result.Children.Add(SetLabelProperties(usualPropertyTitle));

                usualProperty = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[0, 1]
                };
                result.Children.Add(SetLabelProperties(usualProperty));
            }
            else
            {
                usualPropertyTitle = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[0, 0]
                };
                result.Children.Add(SetLabelProperties(usualPropertyTitle));

                usualProperty = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[0, 1]
                };
                result.Children.Add(SetLabelProperties(usualProperty));

                specialEffectTitle = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[1, 0]
                };
                result.Children.Add(SetLabelProperties(specialEffectTitle));

                specialEffect = new Label
                {
                    Text = CreateArmorFromData(fullResourcePath).ReturnValues()[1, 1]
                };
                result.Children.Add(SetLabelProperties(specialEffect));                
            }

            return result;
        }

        private StackLayout FillHelmets(bool hasSpecialEffects, string fullResourcePath, StackLayout result)
        {
            Label usualPropertyTitle;
            Label usualProperty;
            Label specialEffect;
            Label specialEffectTitle;

            if(!hasSpecialEffects)
            {               
                usualPropertyTitle = new Label
                {
                    Text = CreateHelmetFromData(fullResourcePath).ReturnValues()[0, 0]
                };
                result.Children.Add(SetTitleLabelProperties(usualPropertyTitle));

                usualProperty = new Label
                {
                    Text = CreateHelmetFromData(fullResourcePath).ReturnValues()[0, 1]
                };
                result.Children.Add(SetTitleLabelProperties(usualProperty));

                return result;
            }
            else
            {
                usualPropertyTitle = new Label
                {
                    Text = CreateHelmetFromData(fullResourcePath).ReturnValues()[0, 0]
                };
                result.Children.Add(SetTitleLabelProperties(usualPropertyTitle));

                usualProperty = new Label
                {
                    Text = CreateHelmetFromData(fullResourcePath).ReturnValues()[0, 1]
                };
                result.Children.Add(SetLabelProperties(usualProperty));

                specialEffectTitle = new Label
                {
                    Text = CreateHelmetFromData(fullResourcePath).ReturnValues()[1, 0]
                };
                result.Children.Add(SetTitleLabelProperties(specialEffectTitle));

                specialEffect = new Label
                {
                    Text = CreateHelmetFromData(fullResourcePath).ReturnValues()[1, 1]
                };
                result.Children.Add(SetLabelProperties(specialEffect));

                return result;
            }
        }
        #endregion

        #region UImethods
        private Label SetLabelProperties(Label toSet)
        {
            toSet.FontSize = 17;
            toSet.Margin = 3;
            toSet.LineHeight = 2;
            toSet.TextColor = Xamarin.Forms.Color.White;

            return toSet;
        }

        private Label SetTitleLabelProperties(Label toSet)
        {
            toSet.Margin = 3;
            toSet.LineHeight = 1;
            toSet.TextColor = Xamarin.Forms.Color.White;
            toSet.TextType = TextType.Html;

            toSet.Font = Font.SystemFontOfSize(17)
              .WithAttributes(FontAttributes.Bold);

            return toSet;
        }
        #endregion

        #region CreatingObjects
        private Helmet CreateHelmetFromData(string resourcePath)
        {
            ResourceManager resourceManager = new ResourceManager(resourcePath, Assembly.GetExecutingAssembly());
            Helmet result;

            try
            {
                string headshotReduction = resourceManager.GetString("HeadshotRed");
                string specialEffect = resourceManager.GetString("SpecialEffects");

                result = new Helmet(headshotReduction, specialEffect);
                return result;
            }
            catch(Exception)
            {
                string headshotReduction = resourceManager.GetString("HeadshotRed");
                result = new Helmet(headshotReduction);
                return result;
            }
        }

        private Armor CreateArmorFromData(string resourcePath)
        {
            ResourceManager resourceManager = new ResourceManager(resourcePath, Assembly.GetExecutingAssembly());
            Armor result;

            try
            {
                string armorPoints = resourceManager.GetString("ArmorPoints");
                string specialEffect = resourceManager.GetString("SpecialEffects");
                string toEvolve = resourceManager.GetString("NextStageReq");

                result = new Armor(armorPoints, specialEffect, toEvolve);
                return result;
            }
            catch (Exception)
            {
                try
                {
                    string armorPoints = resourceManager.GetString("ArmorPoints");
                    string specialEffect = resourceManager.GetString("SpecialEffects");
                    result = new Armor(armorPoints, specialEffect);
                    return result;
                }
                catch(Exception)
                {
                    try
                    {
                        string armorPoints = resourceManager.GetString("ArmorPoints");
                        string toEvolve = resourceManager.GetString("NextStageReq");
                        result = new Armor(armorPoints, toEvolve);
                        return result;
                    }
                    catch(Exception)
                    {
                        string armorPoints = resourceManager.GetString("ArmorPoints");
                        result = new Armor(armorPoints);
                        return result;
                    }
                }
            }
        }

        private KnockdownShield CreateKnockdownShieldFromData(string resourcePath)
        {
            ResourceManager resourceManager = new ResourceManager(resourcePath, Assembly.GetExecutingAssembly());
            KnockdownShield result;

            try
            {
                string shieldPoints = resourceManager.GetString("ShieldPoints");
                string specialEffect = resourceManager.GetString("SpecialEffects");

                result = new KnockdownShield(shieldPoints, specialEffect);
                return result;
            }
            catch (Exception)
            {
                string armorPoints = resourceManager.GetString("ShieldPoints");
                result = new KnockdownShield(armorPoints);
                return result;
            }
        }

        private Backpack CreateBackpackFromData(string resourcePath)
        {
            ResourceManager resourceManager = new ResourceManager(resourcePath, Assembly.GetExecutingAssembly());
            Backpack result;

            try
            {
                string additionalSlots = resourceManager.GetString("AdditionalSlots");
                string specialEffect = resourceManager.GetString("SpecialEffects");

                result = new Backpack(additionalSlots, specialEffect);
                return result;
            }
            catch (Exception)
            {
                string additionalSlots = resourceManager.GetString("AdditionalSlots");
                result = new Backpack(additionalSlots);
                return result;
            }
        }
        #endregion
    }
}