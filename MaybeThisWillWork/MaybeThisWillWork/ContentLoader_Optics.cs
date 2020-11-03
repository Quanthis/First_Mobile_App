using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Text;
using Xamarin.Forms;

namespace MaybeThisWillWork
{
    public class ContentLoader_Optics
    {
        public enum Sights
        {
            Classicx1,
            Holox1,
            Classicx2,
            Holox2,
            Rangerx3,
            AOGx2_4,
            Digitalx1,
            Sniperx6,
            Sniperx4_8,
            Digitalx4_10
        };

        private Sights sight;
        private StackLayout layout;
        private Optics optics;

        public ContentLoader_Optics(Sights sight, StackLayout layout)
        {
            this.sight = sight;
            this.layout = layout;
        }

        public StackLayout Fill()
        {
            string allSightsPath = "MaybeThisWillWork.Sights_Data.";
            string fullPath;

            switch (sight)
            {
                case Sights.Classicx1:

                    fullPath = allSightsPath + "Classicx1Data";
                    layout = FillHopup(fullPath);
                    return layout;

                case Sights.Classicx2:

                    fullPath = allSightsPath + "Classicx12Data";
                    layout = FillHopup(fullPath);
                    return layout;

                case Sights.Holox1:

                    fullPath = allSightsPath + "Holox1Data";
                    layout = FillHopup(fullPath);
                    return layout;

                case Sights.Holox2:

                    fullPath = allSightsPath + "Holox2Data";
                    layout = FillHopup(fullPath);
                    return layout;

                case Sights.Digitalx1:

                    fullPath = allSightsPath + "Digitalx1Data";
                    layout = FillHopup(fullPath);
                    return layout;

                case Sights.Rangerx3:

                    fullPath = allSightsPath + "Rangerx3Data";
                    layout = FillHopup(fullPath);
                    return layout;

                case Sights.AOGx2_4:

                    fullPath = allSightsPath + "AOGx2_4Data";
                    layout = FillHopup(fullPath);
                    return layout;

                case Sights.Sniperx6:

                    fullPath = allSightsPath + "Sniperx6Data";
                    layout = FillHopup(fullPath);
                    return layout;

                case Sights.Sniperx4_8:

                    fullPath = allSightsPath + "Sniperx4_8Data";
                    layout = FillHopup(fullPath);
                    return layout;

                case Sights.Digitalx4_10:

                    fullPath = allSightsPath + "Digitalx4_10Data";
                    layout = FillHopup(fullPath);
                    return layout;

                default: 
                    
                    return layout;
            }
        }

        private StackLayout FillHopup(string fullPath)
        {
            Label propertyTitle;
            Label property;
            Label compatibileWeaponsTitle;

            optics = CreateOpticsFromData(fullPath);
            string[,] hopupresults = optics.ReturnProperty();

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

            layout.Children.Add(SetTitleLabelProperties(propertyTitle));
            layout.Children.Add(SetLabelProperties(property));
            layout.Children.Add(SetTitleLabelProperties(compatibileWeaponsTitle));

            return layout;
        }

        public List<Button> GetButtons()
        {
            Button button;
            List<Button> compatibileWeapons = new List<Button>();
            List<string> compatibileWeaponsList = optics.ReturnCompatibileWeapons();

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

        private Optics CreateOpticsFromData(string resourcePath)
        {
            ResourceManager resourceManager = new ResourceManager(resourcePath, Assembly.GetExecutingAssembly());
            Optics result;

            string description = resourceManager.GetString("description");
            string compatibileWeapons = resourceManager.GetString("compatibileWeapons");

            result = new Optics(description, compatibileWeapons);

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
