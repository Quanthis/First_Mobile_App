using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MaybeThisWillWork
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        private void Handle_Clicked(object sender, EventArgs e)
        {
            ++count;
            //((Button)sender).Text = $"You clicked {count} times.";
            Handle_Clicked_Label.Text = $"You clicked {count} times.";
        }

        private async void TestButton_Click(object sender, EventArgs e)
        {
            await DisplayAlert("Information", "You've pressed test button", "OK");
        }
    }
}
