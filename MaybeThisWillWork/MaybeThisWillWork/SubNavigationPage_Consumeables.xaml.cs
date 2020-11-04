using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MaybeThisWillWork.ConsumeableContentPages;

namespace MaybeThisWillWork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubNavigationPage_Consumeables : ContentPage
    {
        public SubNavigationPage_Consumeables()
        {
            InitializeComponent();
        }

        private async void MoveToSyringe(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Syringe());
        }

        private async void MoveToMedKit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Medkit());
        }

        private async void MoveToShieldCell(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShieldCell());
        }

        private async void MoveToShieldBattery(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShieldBattery());
        }

        private async void MoveToPhoenixKit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PhoenixKit());
        }

        private async void MoveToUltimateAccelerant(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UltimateAccelerant());
        }
    }
}