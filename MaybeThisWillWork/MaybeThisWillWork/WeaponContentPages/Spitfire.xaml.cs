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
    public partial class Spitfire : ContentPage
    {
        public Spitfire()
        {
            InitializeComponent();
            ContentLoader content = new ContentLoader(ContentLoader.Weapons.Spitfire);
            WeaponInfo.Children.Add(content.Fill());
        }
    }
}