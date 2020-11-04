using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.CharacterContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Wattson : ContentPage
    {
        public Wattson()
        {
            InitializeComponent();
            ContentLoader_Characters character = new ContentLoader_Characters(ContentLoader_Characters.Characters.Wattson);
            PageContent = character.Fill(PageContent);
        }
    }
}