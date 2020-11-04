using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.CharacterContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Octane : ContentPage
    {
        public Octane()
        {
            InitializeComponent();
            ContentLoader_Characters character = new ContentLoader_Characters(ContentLoader_Characters.Characters.Octane);
            PageContent = character.Fill(PageContent);
        }
    }
}