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
    public partial class BackpackLv4 : ContentPage
    {
        public BackpackLv4()
        {
            InitializeComponent();
            ContentLoader_DefensiveGear content = new ContentLoader_DefensiveGear(ContentLoader_DefensiveGear.DefensiveGears.Backpack, ContentLoader_DefensiveGear.GearLevels.Lv4);
            PageContent = content.Fill(PageContent);
        }
    }
}