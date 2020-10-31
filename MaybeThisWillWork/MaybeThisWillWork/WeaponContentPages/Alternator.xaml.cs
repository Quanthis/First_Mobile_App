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
    public partial class Alternator : ContentPage
    {
        public Alternator()
        {
            InitializeComponent();
            ContentLoader content = new ContentLoader(ContentLoader.Weapons.Alternator);
            AlternatorInfo.Children.Add(content.Fill());
        }
    }
}