using MaybeThisWillWork.DefensiveGear_Data;
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
    public partial class SubNavigationPage_Armors : ContentPage
    {
        public SubNavigationPage_Armors()
        {
            InitializeComponent();
        }

        private async void MoveToHelmetLv1Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.HelmetLv1());
        }

        private async void MoveToHelmetLv2Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.HelmetLv2());
        }

        private async void MoveToHelmetLv3Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.HelmetLv3());
        }

        private async void MoveToHelmetLv4Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.HelmetLv4());
        }
    }
}