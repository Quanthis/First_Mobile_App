using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.WeaponContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TripleTakexaml : ContentPage
    {
        public TripleTakexaml()
        {
            InitializeComponent();
            ContentLoader content = new ContentLoader(ContentLoader.Weapons.TripleTake);
            WeaponInfo.Children.Add(content.Fill());
        }
    }
}