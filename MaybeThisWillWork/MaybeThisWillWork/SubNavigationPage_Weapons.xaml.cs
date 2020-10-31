using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubNavigationPage_Weapons : ContentPage
    {
        public SubNavigationPage_Weapons()
        {
            InitializeComponent();
        }

        private async void MoveToR301Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new R301());
        }

        private async void MoveToFlatlinePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Flatline());
        }


    }
}