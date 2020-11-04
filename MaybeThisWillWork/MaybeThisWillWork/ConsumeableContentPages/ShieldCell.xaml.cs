using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.ConsumeableContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShieldCell : ContentPage
    {
        public ShieldCell()
        {
            InitializeComponent();
            ContentLoader_Consumealbes contentLoader = new ContentLoader_Consumealbes(ContentLoader_Consumealbes.Consumeables.ShieldCell, PageContent);
            PageContent = contentLoader.Fill();
        }
    }
}