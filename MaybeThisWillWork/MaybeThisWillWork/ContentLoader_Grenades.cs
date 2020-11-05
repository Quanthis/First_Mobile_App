using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Text;
using Xamarin.Forms;

namespace MaybeThisWillWork
{
    public class ContentLoader_Grenades
    {
        public enum Grenades
        {
            ArcStar,
            FragGrenade,
            ThermiteGrenade
        };

        private Grenades grenade;
        private StackLayout pageContent;

        public ContentLoader_Grenades(Grenades grenade, StackLayout pageContent)
        {
            this.grenade = grenade;
            this.pageContent = pageContent;
        }

        public StackLayout Fill()
        {
            string allGrenadesResourcePath = "MaybeThisWillWork.Grenades_Data.";
            string fullPath;

            switch (grenade)
            {
                case Grenades.ArcStar:

                    fullPath = allGrenadesResourcePath + "ArcStarData";

                    pageContent = FillGrenade(pageContent, fullPath);

                    return pageContent;

                case Grenades.FragGrenade:

                    fullPath = allGrenadesResourcePath + "FragGrenadeData";

                    pageContent = FillGrenade(pageContent, fullPath);

                    return pageContent;

                case Grenades.ThermiteGrenade:

                    fullPath = allGrenadesResourcePath + "ThermiteGrenadaData";

                    pageContent = FillGrenade(pageContent, fullPath);

                    return pageContent;

                default:

                    Label errorLabel = new Label
                    {
                        Text = "Sorry, an error has occured",
                        TextColor = Xamarin.Forms.Color.Red                   
                    };

                    pageContent.Children.Add(errorLabel);

                    return pageContent;
            }
        }

        private StackLayout FillGrenade(StackLayout result, string fullResourcePath)
        {
            Grenade grenade = CreateGrenadeFromData(fullResourcePath);

            Label desciptionTitle;
            Label description;
            Label damageTitle;
            Label damage;
            string[,] grendeValues = grenade.ReturnValues();
            

            desciptionTitle = new Label
            {
                Text = grendeValues[0, 0]
            };

            description = new Label
            {
                Text = grendeValues[0, 1]
            };

            damageTitle = new Label
            {
                Text = grendeValues[1, 0]
            };

            damage = new Label
            {
                Text = grendeValues[1, 1]
            };

            /*try
            {
                ImageSource imageSource = grenade.GetImageSource();

                Image image = new Image
                {
                    Source = imageSource
                };

                result.Children.Add(image);
            }
            catch (Exception)
            {
                Label errorLabel = new Label
                {
                    Text = "Error has occured while loading image",
                    TextColor = Color.White
                };
                result.Children.Add(errorLabel);
            }*/

            result.Children.Add(SetTitleLabelProperties(desciptionTitle));
            result.Children.Add(SetLabelProperties(description));
            result.Children.Add(SetTitleLabelProperties(damageTitle));
            result.Children.Add(SetLabelProperties(damage));

            return result;
        }

        public Grenade CreateGrenadeFromData(string resourcePath)
        {
          /*  try
            {
                ResourceManager resourceManager = new ResourceManager(resourcePath, Assembly.GetExecutingAssembly());
                Grenade result;

                string description = resourceManager.GetString("description");
                string damage = resourceManager.GetString("damage");
                string imageSource = resourceManager.GetString("imagePath");

                result = new Grenade(description, damage, imageSource);

                return result;
            }*/
           // catch(Exception)
            {
                ResourceManager resourceManager = new ResourceManager(resourcePath, Assembly.GetExecutingAssembly());
                Grenade result;

                string description = resourceManager.GetString("description");
                string damage = resourceManager.GetString("damage");

                result = new Grenade(description, damage);

                return result;
            }
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

        [Obsolete]
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
