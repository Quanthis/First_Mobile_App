using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.WeaponContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Wingman : ContentPage
    {
        public Wingman()
        {
            InitializeComponent();
            try
            {
                ContentLoader content = new ContentLoader(ContentLoader.Weapons.Wingman);
                WeaponInfo.Children.Add(content.Fill());
            }
            catch(Exception)
            {
                Navigation.PopToRootAsync();
                DisplayAlert("Error", "Sorry, an unexpected error has occured. Content cannot be loaded", "OK");
            }
        }
    }
}