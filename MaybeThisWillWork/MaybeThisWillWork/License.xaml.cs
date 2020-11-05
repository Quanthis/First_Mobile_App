using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class License : ContentPage
    {
        public License()
        {
            InitializeComponent();
        }

        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });
    }
}