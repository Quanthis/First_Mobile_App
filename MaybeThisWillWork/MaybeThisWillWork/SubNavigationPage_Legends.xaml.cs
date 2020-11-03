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
    }
}