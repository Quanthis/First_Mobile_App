using MaybeThisWillWork.Grenades_Data;
using MaybeThisWillWork.GrenadesContentPages;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubNavigationPage_Grenades : ContentPage
    {
        public SubNavigationPage_Grenades()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.DarkGray;
        }

        private async void MoveToArcStarSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArcStar());
        }

        private async void MoveToFragGrenadeSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FragGrenade());
        }

        private async void MoveToThermiteGrenadeSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThermiteGrenade());
        }
    }
}