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
    public partial class KnockDownShieldLv2 : ContentPage
    {
        public KnockDownShieldLv2()
        {
            InitializeComponent();
            ContentLoader_DefensiveGear content = new ContentLoader_DefensiveGear(ContentLoader_DefensiveGear.DefensiveGears.KnockdownShield, ContentLoader_DefensiveGear.GearLevels.Lv2);
            PageContent = content.Fill(PageContent);
        }
    }
}