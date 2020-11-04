using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.ConsumeableContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Medkit : ContentPage
    {
        public Medkit()
        {
            InitializeComponent();
            ContentLoader_Consumealbes contentLoader = new ContentLoader_Consumealbes(ContentLoader_Consumealbes.Consumeables.MedKit, PageContent);
            PageContent = contentLoader.Fill();
        }
    }
}