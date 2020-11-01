﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaybeThisWillWork.WeaponContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lstar : ContentPage
    {
        public Lstar()
        {
            InitializeComponent();
            ContentLoader_Weapon content = new ContentLoader_Weapon(ContentLoader_Weapon.Weapons.LSTAR);
            WeaponInfo.Children.Add(content.Fill());
        }
    }
}