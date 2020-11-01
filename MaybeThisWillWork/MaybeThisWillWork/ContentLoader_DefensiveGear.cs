using System;
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
            Lv4
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

            string allWeaponsResourcePath = "MaybeThisWillWork.DefensiveGear_Data.";
            string fullPath;

            switch (gearType)
            {
                case DefensiveGears.Helmet:

                    switch(gearLevel)
                    {
                        case GearLevels.Lv1:

                            fullPath = allWeaponsResourcePath + "HelmetLv1";

                            result = FillHelmets(false, fullPath, result);                            

                            return result;

                        case GearLevels.Lv2:

                            fullPath = allWeaponsResourcePath + "HelmetLv2";

                            result = FillHelmets(false, fullPath, result);

                            return result;

                        case GearLevels.Lv3:

                            fullPath = allWeaponsResourcePath + "HelmetLv3";

                            result = FillHelmets(false, fullPath, result);

                            return result;

                        case GearLevels.Lv4:

                            fullPath = allWeaponsResourcePath + "HelmetLv4";

                            result = FillHelmets(true, fullPath, result);

                            return result;



                        default: break;
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
                result.Children.Add(SetLabelProperties(usualPropertyTitle));

                usualProperty = new Label
                {
                    Text = CreateHelmetFromData(fullResourcePath).ReturnValues()[0, 1]
                };
                result.Children.Add(SetLabelProperties(usualProperty));

                return result;
            }
            else
            {
                usualPropertyTitle = new Label
                {
                    Text = CreateHelmetFromData(fullResourcePath).ReturnValues()[0, 0]
                };
                result.Children.Add(SetLabelProperties(usualPropertyTitle));

                usualProperty = new Label
                {
                    Text = CreateHelmetFromData(fullResourcePath).ReturnValues()[0, 1]
                };
                result.Children.Add(SetLabelProperties(usualProperty));

                specialEffectTitle = new Label
                {
                    Text = CreateHelmetFromData(fullResourcePath).ReturnValues()[1, 0]
                };
                result.Children.Add(SetLabelProperties(specialEffectTitle));

                specialEffect = new Label
                {
                    Text = CreateHelmetFromData(fullResourcePath).ReturnValues()[1, 1]
                };
                result.Children.Add(SetLabelProperties(specialEffect));

                return result;
            }
        }

        private Label SetLabelProperties(Label toSet)
        {
            toSet.FontSize = 17;
            toSet.Margin = 3;
            toSet.LineHeight = 2;
            toSet.TextColor = Xamarin.Forms.Color.White;

            return toSet;
        }

        private Helmet CreateHelmetFromData(string resourcePath)
        {
            ResourceManager resourceManager = new ResourceManager(resourcePath, Assembly.GetExecutingAssembly());
            //ResourceManager resourceManager = new ResourceManager("MaybeThisWillWork.DefensiveGear_Data.HelmetLv1", Assembly.GetExecutingAssembly());

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
    }
}
