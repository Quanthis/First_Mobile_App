using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.GrenadesContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThermiteGrenade : ContentPage
    {
        public ThermiteGrenade()
        {
            InitializeComponent();
            ContentLoader_Grenades contentLoader = new ContentLoader_Grenades(ContentLoader_Grenades.Grenades.ThermiteGrenade, PageContent);
            PageContent = contentLoader.Fill();
        }
    }
}