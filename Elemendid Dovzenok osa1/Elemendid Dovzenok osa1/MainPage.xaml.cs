using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendid_Dovzenok_osa1
{
    public partial class MainPage : ContentPage
    {
        private object editor;
        private int picker_SelectedIndex;

        public MainPage()
        {
     
        }
        Image img = new Image();
        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (picker_SelectedIndex == 0)
            {
                img.Source = "valga.png";
            }
            if (picker_SelectedIndex == 1)
            {
                img.Source = "viljandi.png";
            }
            if (picker_SelectedIndex == 1)
            {
                img.Source = "võru.png";
            }
            if (picker_SelectedIndex == 1)
            {
                img.Source = "ida.png";
            }
            if (picker_SelectedIndex == 1)
            {
                img.Source = "jõgeva.png";
            }
        }

        private void picker1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
