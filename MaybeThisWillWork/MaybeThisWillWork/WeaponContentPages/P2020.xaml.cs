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
    public partial class P2020 : ContentPage
    {
        public P2020()
        {
            InitializeComponent();
            ContentLoader content = new ContentLoader(ContentLoader.Weapons.P2020);
            WeaponInfo.Children.Add(content.Fill());
        }
    }
}