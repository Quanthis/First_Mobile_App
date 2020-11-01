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

        private async void MoveToArmorLv1Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.ArmorLv1());
        }

        private async void MoveToArmorLv2Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.Armor2());
        }

        private async void MoveToArmorLv3Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.ArmorLv3());
        }

        private async void MoveToArmorLv4Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.ArmorLv4());
        }

        private async void MoveToArmorLv5Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.ArmorLv5());
        }

        private async void MoveToKnockdownShieldLv1Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.KnockdownShieldLv1());
        }

        private async void MoveToKnockdownShieldLv2Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.KnockDownShieldLv2());
        }

        private async void MoveToKnockdownShieldLv3Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.KnockdownShieldLv3());
        }

        private async void MoveToKnockdownShieldLv4Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.KnockdownShieldLv4());
        }

        private async void MoveToBackpackLv1Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.Backpack());
        }

        private async void MoveToBackpackLv2Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.BackpackLv2());
        }

        private async void MoveToBackpackLv3Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.BackpackLv3());
        }

        private async void MoveToBackpackLv4Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DefensiveGear_Pages.BackpackLv4());
        }
    }
}