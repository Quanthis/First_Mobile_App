using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.CharacterContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Caustuc : ContentPage
    {
        public Caustuc()
        {
            InitializeComponent();
            ContentLoader_Characters character = new ContentLoader_Characters(ContentLoader_Characters.Characters.Caustic);
            PageContent = character.Fill(PageContent);
        }
    }
}