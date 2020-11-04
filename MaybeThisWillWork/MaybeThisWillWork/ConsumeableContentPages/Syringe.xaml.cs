using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.ConsumeableContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Syringe : ContentPage
    {
        public Syringe()
        {
            InitializeComponent();

            ContentLoader_Consumealbes contentLoader = new ContentLoader_Consumealbes(ContentLoader_Consumealbes.Consumeables.Syringe, PageContent);
            PageContent = contentLoader.Fill();
        }
    }
}