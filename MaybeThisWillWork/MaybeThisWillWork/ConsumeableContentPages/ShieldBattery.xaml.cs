using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.ConsumeableContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShieldBattery : ContentPage
    {
        public ShieldBattery()
        {
            InitializeComponent();
            ContentLoader_Consumealbes contentLoader = new ContentLoader_Consumealbes(ContentLoader_Consumealbes.Consumeables.ShieldBattery, PageContent);
            PageContent = contentLoader.Fill();
        }
    }
}