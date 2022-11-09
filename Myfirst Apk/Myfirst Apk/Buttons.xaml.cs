using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Myfirst_Apk
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buttons : ContentPage
    {
        public Buttons()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            lbldisplay.Text = "Umesh Ponnayek";
        }
    }
}