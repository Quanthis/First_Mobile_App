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
    public partial class KnockdownShieldLv3 : ContentPage
    {
        public KnockdownShieldLv3()
        {
            InitializeComponent();
            ContentLoader_DefensiveGear content = new ContentLoader_DefensiveGear(ContentLoader_DefensiveGear.DefensiveGears.KnockdownShield, ContentLoader_DefensiveGear.GearLevels.Lv3);
            PageContent = content.Fill(PageContent);
        }
    }
}