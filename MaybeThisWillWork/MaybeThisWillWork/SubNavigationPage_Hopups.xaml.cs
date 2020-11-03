using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubNavigationPage_Hopups : ContentPage
    {
        public SubNavigationPage_Hopups()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.DarkGray;
        }

        private async void MoveToBarrelStabilizerSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HopupContentPages.BarrelStabilizer());
        }

        private async void MoveToEnergyMagazineExtensionSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HopupContentPages.EnergyMagazineExtension());
        }

        private async void MoveToHeavyMagazineExtensionSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HopupContentPages.HeavyMagazineExtension());
        }

        private async void MoveToLightMagazineExtensionSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HopupContentPages.LightMagazineExtension());
        }

        private async void MoveToStandardStockSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HopupContentPages.StandardStock());
        }

        private async void MoveToSniperStockSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HopupContentPages.SniperStock());
        }

        private async void MoveToExtendedSniperMagSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HopupContentPages.SniperMagazineExtension());
        }

        private async void MoveToShotgunBoltSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HopupContentPages.ShotgunBolt());
        }
    }
}