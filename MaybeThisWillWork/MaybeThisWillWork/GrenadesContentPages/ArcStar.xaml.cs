using System;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArcStar : ContentPage
    {
        public ArcStar()
        {
            InitializeComponent();
            ContentLoader_Grenades contentLoader = new ContentLoader_Grenades(ContentLoader_Grenades.Grenades.ArcStar, PageContent);
            PageContent = contentLoader.Fill();
        }
    }
}