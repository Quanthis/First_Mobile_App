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
    public partial class G7Scout : ContentPage
    {
        public G7Scout()
        {
            InitializeComponent();
            ContentLoader content = new ContentLoader(ContentLoader.Weapons.G7Scout);
            G7ScoutInfo.Children.Add(content.Fill());
        }
    }
}