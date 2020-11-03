using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.GrenadesContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FragGrenade : ContentPage
    {
        public FragGrenade()
        {
            InitializeComponent();
            ContentLoader_Grenades contentLoader = new ContentLoader_Grenades(ContentLoader_Grenades.Grenades.FragGrenade, PageContent);
            PageContent = contentLoader.Fill();
        }
    }
}