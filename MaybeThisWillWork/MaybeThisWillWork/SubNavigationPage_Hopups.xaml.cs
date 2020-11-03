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
        }

        private async void MoveToBarrelStabilizerSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HopupContentPages.BarrelStabilizer());
        }
    }
}