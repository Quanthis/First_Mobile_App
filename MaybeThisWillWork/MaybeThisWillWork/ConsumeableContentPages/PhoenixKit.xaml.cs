using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.ConsumeableContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhoenixKit : ContentPage
    {
        public PhoenixKit()
        {
            InitializeComponent();
            ContentLoader_Consumealbes contentLoader = new ContentLoader_Consumealbes(ContentLoader_Consumealbes.Consumeables.PhoenixKit, PageContent);
            PageContent = contentLoader.Fill();
        }
    }
}