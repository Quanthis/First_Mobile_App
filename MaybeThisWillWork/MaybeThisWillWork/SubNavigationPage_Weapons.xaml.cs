using MaybeThisWillWork.WeaponContentPages;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubNavigationPage_Weapons : ContentPage
    {
        public SubNavigationPage_Weapons()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.DarkGray;
            ChangeMargins();
        }

        private async void ChangeMargins()
        {
            for (int i = 0; i < PageContent.Children.Count; ++i)
            {
                PageContent.Children[i].Margin = 7;
            }
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
        private async void MoveToPeacekeeperPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Peacekeeper());
        }
    }
}