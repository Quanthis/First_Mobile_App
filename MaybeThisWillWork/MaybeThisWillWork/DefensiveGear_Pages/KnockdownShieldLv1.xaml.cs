﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.DefensiveGear_Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KnockdownShieldLv1 : ContentPage
    {
        public KnockdownShieldLv1()
        {
            InitializeComponent();
            ContentLoader_DefensiveGear content = new ContentLoader_DefensiveGear(ContentLoader_DefensiveGear.DefensiveGears.KnockdownShield, ContentLoader_DefensiveGear.GearLevels.Lv1);
            PageContent = content.Fill(PageContent);
        }
    }
}