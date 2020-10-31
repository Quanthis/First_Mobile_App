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
    public partial class Prowler : ContentPage
    {
        public Prowler()
        {
            InitializeComponent();
            ContentLoader content = new ContentLoader(ContentLoader.Weapons.Prowler);
            WeaponInfo.Children.Add(content.Fill());
        }
    }
}