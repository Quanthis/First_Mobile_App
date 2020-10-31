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
    public partial class ChargeRifle : ContentPage
    {
        public ChargeRifle()
        {
            InitializeComponent();
            ContentLoader content = new ContentLoader(ContentLoader.Weapons.ChargeRifle);
            ChargeRifleInfo.Children.Add(content.Fill());
        }
    }
}