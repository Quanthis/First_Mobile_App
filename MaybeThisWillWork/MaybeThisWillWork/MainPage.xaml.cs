using MaybeThisWillWork.CharacterContentPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MaybeThisWillWork
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
    }
}
