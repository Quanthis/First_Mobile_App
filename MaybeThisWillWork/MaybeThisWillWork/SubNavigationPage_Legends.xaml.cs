using MaybeThisWillWork.CharacterContentPages;
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
    public partial class SubNavigationPage_Legends : ContentPage
    {
        public SubNavigationPage_Legends()
        {
            InitializeComponent();
        }

        private async void MoveToGibraltarSubpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Gibraltar());
        }
    }
}