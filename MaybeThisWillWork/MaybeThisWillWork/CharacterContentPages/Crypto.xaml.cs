using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.CharacterContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Crypto : ContentPage
    {
        public Crypto()
        {
            InitializeComponent();
            ContentLoader_Characters character = new ContentLoader_Characters(ContentLoader_Characters.Characters.Crypto);
            PageContent = character.Fill(PageContent);
        }
    }
}