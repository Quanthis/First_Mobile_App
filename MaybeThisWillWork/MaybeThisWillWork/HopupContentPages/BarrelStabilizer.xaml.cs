using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.HopupContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarrelStabilizer : ContentPage
    {
        public BarrelStabilizer()
        {
            InitializeComponent();
            ContentLoader_Hopups contentLoader = new ContentLoader_Hopups(ContentLoader_Hopups.Hopups.BarrelStabilizer, PageContent);
            PageContent = contentLoader.Fill();
        }

        /*public async void MoveToR99Subpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MaybeThisWillWork.WeaponContentPages.R99());
        }

        public async void Move()
        {
            MoveToR99Subpage(sender, EventArgs.Empty);
        }*/
    }
}