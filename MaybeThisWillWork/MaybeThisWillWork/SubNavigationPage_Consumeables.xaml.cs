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
    }
}