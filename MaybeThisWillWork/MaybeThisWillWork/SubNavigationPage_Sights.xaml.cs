using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubNavigationPage_Sights : ContentPage
    {
        public SubNavigationPage_Sights()
        {
            InitializeComponent();
        }

        private async void MoveToDigitalx1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OpticsContentPages.Digitalx1());
        }

        private async void MoveToClassicx1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OpticsContentPages.Classicx1());
        }

        private async void MoveToClassicx2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OpticsContentPages.Classicx2());
        }

        private async void MoveToHolox1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OpticsContentPages.Holox1());
        }

        private async void MoveToHolox2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OpticsContentPages.Holox2());
        }

        private async void MoveToRangerx3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OpticsContentPages.Rangerx3());
        }
        private async void MoveToAOGx2_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OpticsContentPages.AOGx2_4());
        }

        private async void MoveToSniperx6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OpticsContentPages.Sniperx6());
        }

        private async void MoveToSniperx4_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OpticsContentPages.Sniperx4_10());
        }

        private async void MoveToSniperx4_10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OpticsContentPages.Digitalx4_10());
        }
    }
}