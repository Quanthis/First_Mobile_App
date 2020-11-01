using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.DefensiveGear_Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelmetLv3 : ContentPage
    {
        public HelmetLv3()
        {
            InitializeComponent();
            ContentLoader_DefensiveGear content = new ContentLoader_DefensiveGear(ContentLoader_DefensiveGear.DefensiveGears.Helmet, ContentLoader_DefensiveGear.GearLevels.Lv3);
            Content = content.Fill(Content);
        }
    }
}