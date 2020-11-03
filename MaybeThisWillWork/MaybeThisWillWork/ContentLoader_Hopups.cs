using MaybeThisWillWork.HopupContentPages;
using MaybeThisWillWork.WeaponContentPages;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork
{
    public class ContentLoader_Hopups
    {
        public enum Hopups
        {
            BarrelStabilizer,
            LightMagazineExtension,
            HeavyMagazineExtension,
            EnergyMagazineExtension,
            StandardStock,

            SniperStock,
            SniperMagazineExtension,

            ShotgunBolt,

            DoubleTapTrigger,
            Hammerpoint,
            SelectiveReceiver,
            Skullpiercer,
            Turbocharger
        };

        private Hopups hopup;
        private StackLayout stackLayout;
        Hopup hopup1;

        public ContentLoader_Hopups(Hopups hopup, StackLayout stackLayout)
        {
            this.hopup = hopup;
            this.stackLayout = stackLayout;
        }

        public StackLayout Fill()
        {
            string allHopupsPath = "MaybeThisWillWork.Hopups_Data.";
            string fullPath;

            switch(hopup)
            {
                case Hopups.BarrelStabilizer:

                    fullPath = allHopupsPath + "BarrelStabilizerData";

                    stackLayout = FillHopup(fullPath);

                    return stackLayout;

                case Hopups.EnergyMagazineExtension:

                    fullPath = allHopupsPath + "EnergyMagazineExtensionData";

                    stackLayout = FillHopup(fullPath);

                    return stackLayout;

                case Hopups.HeavyMagazineExtension:

                    fullPath = allHopupsPath + "HeavyMagazineExtensionData";

                    stackLayout = FillHopup(fullPath);

                    return stackLayout;

                case Hopups.LightMagazineExtension:

                    fullPath = allHopupsPath + "LightMagazineExtensionData";

                    stackLayout = FillHopup(fullPath);

                    return stackLayout;

                case Hopups.StandardStock:

                    fullPath = allHopupsPath + "StandardStockData";

                    stackLayout = FillHopup(fullPath);

                    return stackLayout;

                default:

                    return stackLayout;
            }
        }

        private StackLayout FillHopup(string fullPath)
        {
            Label propertyTitle;
            Label property;
            Label compatibileWeaponsTitle;

            hopup1 = CreateHopupFromData(fullPath);
            string[,] hopupresults = hopup1.ReturnProperty();

            propertyTitle = new Label
            {
                Text = hopupresults[0, 0]
            };

            property = new Label
            {
                Text = hopupresults[0, 1]
            };

            compatibileWeaponsTitle = new Label
            {
                Text = hopupresults[1, 0]
            };

            stackLayout.Children.Add(SetTitleLabelProperties(propertyTitle));
            stackLayout.Children.Add(SetLabelProperties(property));
            stackLayout.Children.Add(SetTitleLabelProperties(compatibileWeaponsTitle));

            return stackLayout;
        }

        public List<Button> GetButtons()
        {
            Button button;
            List<Button> compatibileWeapons = new List<Button>();
            List<string> compatibileWeaponsList = hopup1.ReturnCompatibileWeapons();

            foreach (var item in compatibileWeaponsList)
            {
                button = new Xamarin.Forms.Button
                {
                    Text = item,
                    AutomationId = $"MoveTo{item}Page"
                };

                compatibileWeapons.Add(button);
            }

            return compatibileWeapons;
        }

        private Hopup CreateHopupFromData(string resourcePath)
        {
            ResourceManager resourceManager = new ResourceManager(resourcePath, Assembly.GetExecutingAssembly());
            Hopup result;

            string property = resourceManager.GetString("property");
            string compatibileWeapons = resourceManager.GetString("compatibileWeapons");

            result = new Hopup(property, compatibileWeapons);

            return result;
        }

        #region UImethods
        private Label SetLabelProperties(Label toSet)
        {
            toSet.FontSize = 17;
            toSet.Margin = 3;
            toSet.LineHeight = 1;
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
    }
}
