using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Text;
using Xamarin.Forms;
using System.Drawing;
using Xamarin.Forms.Markup;

namespace MaybeThisWillWork
{
    public class ContentLoader_Characters
    {
        public enum Characters
        {
            Bloodhound,
            Gibraltar,
            Lifeline,
            Pathfinder,
            Wraith,
            Bangalore,
            Caustic,
            Mirage,
            Octane,
            Wattson,
            Crypto,
            Revenant,
            Loba,
            Rampart
        };

        private Characters character;

        public ContentLoader_Characters(Characters character)
        {
            this.character = character;
        }

        public StackLayout Fill(StackLayout result)
        {
            result.Margin = 20;

            string allDefensiveGearsResourcePath = "MaybeThisWillWork.Characters_Data.";
            string fullPath;

            switch (character)
            {
                case Characters.Gibraltar:

                    fullPath = allDefensiveGearsResourcePath + "GibraltarData";

                    result = FillCharacter(result, fullPath, true);

                    return result;

                case Characters.Bloodhound:

                    fullPath = allDefensiveGearsResourcePath + "BloodhoundData";

                    result = FillCharacter(result, fullPath, true);

                    return result;

                case Characters.Lifeline:

                    fullPath = allDefensiveGearsResourcePath + "LifelineData";

                    result = FillCharacter(result, fullPath, false);

                    return result;


                default:

                    return result;
            }
        }

        private StackLayout FillCharacter(StackLayout result, string fullResourcePath, bool hasAdditionalFeatures)
        {
            Label tactical;
            Label ultimate;
            Label passive;
            Label receivedDamage;
            Label additionalFeature;

            Label tacticalTitle;
            Label ultimateTitle;
            Label passiveTitle;
            Label receivedDamageTitle;
            Label additionalFeatureTitle;

            tacticalTitle = new Label
            {
                Text = CreateCharacterFromData(fullResourcePath).ReturnValues()[0, 0]
            };

            tactical = new Label
            {
                Text = CreateCharacterFromData(fullResourcePath).ReturnValues()[0, 1]
            };

            ultimateTitle = new Label
            {
                Text = CreateCharacterFromData(fullResourcePath).ReturnValues()[1, 0]
            };

            ultimate = new Label
            {
                Text = CreateCharacterFromData(fullResourcePath).ReturnValues()[1, 1]
            };

            passiveTitle = new Label
            {
                Text = CreateCharacterFromData(fullResourcePath).ReturnValues()[2, 0]
            };

            passive = new Label
            {
                Text = CreateCharacterFromData(fullResourcePath).ReturnValues()[2, 1]
            };

            receivedDamageTitle = new Label
            {
                Text = CreateCharacterFromData(fullResourcePath).ReturnValues()[3, 0]
            };

            receivedDamage = new Label
            {
                Text = CreateCharacterFromData(fullResourcePath).ReturnValues()[3, 1]
            };

            result.Children.Add(SetTitleLabelProperties(tacticalTitle));
            result.Children.Add(SetLabelProperties(tactical));
            result.Children.Add(SetTitleLabelProperties(ultimateTitle));
            result.Children.Add(SetLabelProperties(ultimate));
            result.Children.Add(SetTitleLabelProperties(passiveTitle));
            result.Children.Add(SetLabelProperties(passive));
            result.Children.Add(SetTitleLabelProperties(receivedDamageTitle));
            result.Children.Add(SetLabelProperties(receivedDamage));

            if(hasAdditionalFeatures)
            {
                additionalFeatureTitle = new Label
                {
                    Text = CreateCharacterFromData(fullResourcePath).ReturnValues()[4, 0]
                };

                additionalFeature = new Label
                {
                    Text = CreateCharacterFromData(fullResourcePath).ReturnValues()[4, 1]
                };

                result.Children.Add(SetTitleLabelProperties(additionalFeatureTitle));
                result.Children.Add(SetLabelProperties(additionalFeature));
            }

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

        private Character CreateCharacterFromData(string resourcePath)
        {
            ResourceManager resourceManager = new ResourceManager(resourcePath, Assembly.GetExecutingAssembly());
            Character result;

            try
            {
                string tactical = resourceManager.GetString("Tactical");
                string ultimate = resourceManager.GetString("Ultimate");
                string passive = resourceManager.GetString("Passive");
                string damageReceived = resourceManager.GetString("DamageReceiving");
                string additionalFeatures = resourceManager.GetString("Additional");

                result = new Character(tactical, ultimate, damageReceived, passive, additionalFeatures);

                return result;
            }
            catch(Exception)
            {
                string tactical = resourceManager.GetString("Tactical");
                string ultimate = resourceManager.GetString("Ultimate");
                string passive = resourceManager.GetString("Passive");
                string damageReceived = resourceManager.GetString("DamageReceiving");

                result = new Character(tactical, ultimate, damageReceived, passive);

                return result;
            }
        }
    }
}