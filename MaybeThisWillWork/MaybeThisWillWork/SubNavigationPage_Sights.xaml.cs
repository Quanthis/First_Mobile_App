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

        private async void MoveToClassicx1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OpticsContentPages.Classicx1());
        }
    }
}