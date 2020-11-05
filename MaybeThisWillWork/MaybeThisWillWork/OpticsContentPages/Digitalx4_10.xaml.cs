using MaybeThisWillWork.WeaponContentPages;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.OpticsContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Digitalx4_10 : ContentPage
    {
        public Digitalx4_10()
        {
            InitializeComponent();

            ContentLoader_Optics contentLoader = new ContentLoader_Optics(ContentLoader_Optics.Sights.Digitalx4_10, PageContent);
            contentLoader.Fill();

            PageContent = AddButtons(contentLoader);
        }

        private StackLayout AddButtons(ContentLoader_Optics contentLoader)
        {
            List<Button> buttons = contentLoader.GetButtons();

            foreach (var item in buttons)
            {
                try
                {
                    string methodName = item.AutomationId;
                    EventHandler handler = (EventHandler)Delegate.CreateDelegate(typeof(EventHandler), this, methodName, false);
                    item.Clicked += handler;
                    PageContent.Children.Add(item);
                }
                catch (Exception ex)
                {
                    string methodName = AutomationId;

                    Label InfoLabel = new Label
                    {
                        Text = "Method name: " + methodName + "\nThere was an Exception: " + ex,
                        TextColor = Color.White
                    };
                    PageContent.Children.Add(InfoLabel);
                }
            }

            return PageContent;
        }

        #region LoadWeaponPages
        private async void MoveToWeaponsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubNavigationPage_Weapons());
        }

        private async void MoveToR99Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MaybeThisWillWork.WeaponContentPages.R99());
        }

        private async void MoveToR301Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new R301());
        }

        private async void MoveToFlatlinePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Flatline());
        }

        private async void MoveToAlternatorPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Alternator());
        }

        private async void MoveToG7ScoutPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new G7Scout());
        }

        private async void MoveToHavocPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Havoc());
        }

        private async void MoveToHemlokPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hemlok());
        }

        private async void MoveToVoltPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Volt());
        }

        private async void MoveToProwlerPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Prowler());
        }

        private async void MoveToR99Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new R99());
        }

        private async void MoveToChargeRiflePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChargeRifle());
        }

        private async void MoveToLongbowPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Longbow());
        }

        private async void MoveToSentinelPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sentinel());
        }

        private async void MoveToTripleTakePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TripleTakexaml());
        }

        private async void MoveToKraberPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kraber());
        }

        private async void MoveToEva8Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Eva8());
        }

        private async void MoveToMastiffPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mastiff());
        }
        private async void MoveToMozambiquePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mozambique());
        }

        private async void MoveToP2020Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new P2020());
        }

        private async void MoveToWingmanPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Wingman());
        }
        private async void MoveToRe45Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Re45());
        }

        private async void MoveToDevotionPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Devotion());
        }

        private async void MoveToSpitfirePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Spitfire());
        }

        private async void MoveToLstarPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lstar());
        }
        #endregion
    }
}