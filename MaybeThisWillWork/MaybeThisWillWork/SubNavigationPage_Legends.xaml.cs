using MaybeThisWillWork.CharacterContentPages;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubNavigationPage_Legends : ContentPage
    {
        public SubNavigationPage_Legends()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.DarkGray;
        }

        private async void MoveToGibraltarSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Gibraltar());
        }

        private async void MoveToBloodhoundSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bloodhound());
        }

        private async void MoveToLifelineSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lifeline());
        }

        private async void MoveToBangaloreSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bangalore());
        }

        private async void MoveToPathfinderSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pathfinder());
        }

        private async void MoveToWraithSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Wraith());
        }

        private async void MoveToCausticSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Caustuc());
        }

        private async void MoveToCryptoSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Crypto());
        }

        private async void MoveToLobaSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Loba());
        }

        private async void MoveToMirageSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mirage());
        }

        private async void MoveToOctaneSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Octane());
        }

        private async void MoveToRampartSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Rampart());
        }

        private async void MoveToRevenantSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Revenant());
        }

        private async void MoveToWattsonSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Wattson());
        }
    }
}