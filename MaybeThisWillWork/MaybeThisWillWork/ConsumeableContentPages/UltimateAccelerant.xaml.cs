using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.ConsumeableContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UltimateAccelerant : ContentPage
    {
        public UltimateAccelerant()
        {
            InitializeComponent();
            ContentLoader_Consumealbes contentLoader = new ContentLoader_Consumealbes(ContentLoader_Consumealbes.Consumeables.UltimateAccelerant, PageContent);
            PageContent = contentLoader.Fill();
        }
    }
}