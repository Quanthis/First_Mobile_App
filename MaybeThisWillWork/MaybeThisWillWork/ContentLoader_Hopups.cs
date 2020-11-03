using MaybeThisWillWork.HopupContentPages;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;

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

        public ContentLoader_Hopups(Hopups hopup, StackLayout stackLayout)
        {
            this.hopup = hopup;
            this.stackLayout = stackLayout;
        }

        public StackLayout Fill()
        {
            string allHopupsPath = "MaybeThisWillWork.Hopups_Data.";

            switch(hopup)
            {
                case Hopups.BarrelStabilizer:

                    string fullPath = allHopupsPath + "BarrelStabilizerData";

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
            Button button;
            List<Button> compatibileWeapons = new List<Button>();

            Hopup hopup = CreateHopupFromData(fullPath);
            string[,] hopupresults = hopup.ReturnProperty();
            List<string> compatibileWeaponsList = hopup.ReturnCompatibileWeapons();


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

            foreach(var item in compatibileWeaponsList)
            {
                button = new Xamarin.Forms.Button
                {
                    Text = item
                    
                };
                button.Clicked += MoveToR99Subpage;

                compatibileWeapons.Add(button);
            }

            foreach (var item in compatibileWeapons)
            {
                stackLayout.Children.Add(item);
            }

            return stackLayout;
        }

        private async void MoveToR99Subpage(object sender, EventArgs e)
        {
            /*object o = HopupContentPages.BarrelStabilizer;
            o.MoveToR99Subpage();*/
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
