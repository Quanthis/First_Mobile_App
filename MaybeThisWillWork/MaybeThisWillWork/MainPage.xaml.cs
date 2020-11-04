using System;
using Xamarin.Forms;

namespace MaybeThisWillWork
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ChangeMargins();
        }

        private async void ChangeMargins()
        {
            for (int i = 0; i < PageContent.Children.Count; ++i)
            {
                PageContent.Children[i].Margin = 10;
            }
        }

        private async void MoveToWeaponsSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubNavigationPage_Weapons());
        }

        private async void MoveToDefensiveSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubNavigationPage_Armors());
        }

        private async void MoveToLegendsSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubNavigationPage_Legends());
        }

        private async void MoveToGrenadesSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubNavigationPage_Grenades());
        }

        private async void MoveToHopupsSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubNavigationPage_Hopups());
        }

        private async void MoveToOpticsSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubNavigationPage_Sights());
        }

        private async void MoveToConsumeablesSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubNavigationPage_Consumeables());
        }
    }
}
