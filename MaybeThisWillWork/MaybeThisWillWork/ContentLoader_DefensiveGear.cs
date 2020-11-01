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

        private DefensiveGears gearType;

        public ContentLoader_DefensiveGear(DefensiveGears type)
        {
            gearType = type;
        }

        public StackLayout Fill()
        {
            StackLayout result = new StackLayout();

            Label usualPropertyTitle;
            Label usualProperty;
            Label specialEffect;
            Label specialEffectTitle;

            string allWeaponsResourcePath = "MaybeThisWillWork.DefensiveGear_Data.";
            string fullPath;
            string weaponFile;

            switch (gearType)
            {
                case DefensiveGears.Helmet:

                    fullPath = allWeaponsResourcePath + "HelmetLv1";

                    usualPropertyTitle = new Label
                    {
                        Text = CreateHelmetFromData(fullPath).ReturnValues()[0, 0]
                    };


                    return result;

                default:

                    usualProperty = new Label
                    {
                        Text = "Sorry, an error has occured",
                    };

                    result.Children.Add(usualProperty);
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
            Helmet result;

            try
            {
                string headshotReduction = resourceManager.GetString("HeadshotRed");
                string specialEffect = resourceManager.GetString("SpecialEffects");

                result = new Helmet(headshotReduction);
            }
            catch(Exception)
            {
                string headshotReduction = resourceManager.GetString("HeadshotRed");
                result = new Helmet(headshotReduction);
            }

            return result;
        }
    }
}
