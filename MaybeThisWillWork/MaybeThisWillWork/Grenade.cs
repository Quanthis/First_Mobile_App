using System;
using System.Drawing;
using Xamarin.Forms;

namespace MaybeThisWillWork
{
    public class Grenade
    {
        private string property;
        private string damage;
        private ImageSource imageSource;

        /*public Grenade(string property, string damage, ImageSource imageSource)
        {
            this.property = property;
            this.damage = damage;
            this.imageSource = imageSource;
        }*/

        public Grenade(string property, string damage)
        {
            this.property = property;
            this.damage = damage;
        }

        public string [,] ReturnValues()
        {
            string[,] result = new string[2, 2];

            result[0, 0] = "";
            result[0, 1] = property;
            result[1, 0] = "Damage: ";
            result[1, 1] = damage;

            return result;
        }

        /*public ImageSource GetImageSource()
        {
            return imageSource;
        }*/
    }
}
