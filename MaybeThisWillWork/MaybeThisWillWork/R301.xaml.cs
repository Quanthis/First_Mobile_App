using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class R301 : ContentPage
    {
        public R301()
        {
            InitializeComponent();
            ContentLoader content = new ContentLoader(ContentLoader.Weapon.R301);
            R301Info.Children.Add(content.Fill());
        }
    }
}