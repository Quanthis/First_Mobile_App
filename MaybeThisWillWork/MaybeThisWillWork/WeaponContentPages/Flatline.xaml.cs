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
    public partial class Flatline : ContentPage
    {
        public Flatline()
        {
            InitializeComponent();
            ContentLoader content = new ContentLoader(ContentLoader.Weapons.Flatline);
            FlatlineInfo.Children.Add(content.Fill());
        }
    }
}