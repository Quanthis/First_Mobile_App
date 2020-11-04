using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Text;
using Xamarin.Forms;

namespace MaybeThisWillWork
{
    public class ContentLoader_Consumealbes
    {
        public enum Consumeables
        {
            Syringe,
            MedKit,
            ShieldCell,
            ShieldBattery,
            PhoenixKit,
            UltimateAccelerant
        };

        private Consumeables consumeable;
        private StackLayout layout;

        public ContentLoader_Consumealbes(Consumeables consumeable, StackLayout layout)
        {
            this.layout = layout;
            this.consumeable = consumeable;
        }

        public StackLayout Fill()
        {
            string allConsumeablesPath = "MaybeThisWillWork.Consumeables_Data.";
            string fullPath;

            switch(consumeable)
            {
                case Consumeables.Syringe:

                    fullPath = allConsumeablesPath + "SyringeData";
                    layout = FillConsumeable(fullPath);
                    return layout;



                default:

                    return layout;
            }
        }

        private StackLayout FillConsumeable(string fullPath)
        {
            Label property;
            Label usageTime;
            Consumeable consumeable = CreateConsumeableFromData(fullPath);

            property = new Label
            {
                Text = consumeable.ReturnValues()[0]
            };

            usageTime = new Label
            {
                Text = consumeable.ReturnValues()[1]
            };

            layout.Children.Add(SetLabelProperties(property));
            layout.Children.Add(SetLabelProperties(property));

            return layout;
        }

        private Consumeable CreateConsumeableFromData(string resourcePath)
        {
            ResourceManager resourceManager = new ResourceManager(resourcePath, Assembly.GetExecutingAssembly());
            Consumeable result;

            string property = resourceManager.GetString("property");
            string usageTime = resourceManager.GetString("usageTime");

            result = new Consumeable(property, usageTime);

            return result;
        }

        private Label SetLabelProperties(Label toSet)
        {
            toSet.FontSize = 17;
            toSet.Margin = 3;
            toSet.LineHeight = 1;
            toSet.TextColor = Xamarin.Forms.Color.White;

            return toSet;
        }
    }
}
