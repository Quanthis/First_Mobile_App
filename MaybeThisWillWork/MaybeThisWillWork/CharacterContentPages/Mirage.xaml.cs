using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.CharacterContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mirage : ContentPage
    {
        public Mirage()
        {
            InitializeComponent();
            ContentLoader_Characters character = new ContentLoader_Characters(ContentLoader_Characters.Characters.Mirage);
            PageContent = character.Fill(PageContent);
        }
    }
}