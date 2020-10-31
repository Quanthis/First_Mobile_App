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
    public partial class Re45 : ContentPage
    {
        public Re45()
        {
            InitializeComponent();
            ContentLoader content = new ContentLoader(ContentLoader.Weapons.Re45);
            WeaponInfo.Children.Add(content.Fill());
        }
    }
}