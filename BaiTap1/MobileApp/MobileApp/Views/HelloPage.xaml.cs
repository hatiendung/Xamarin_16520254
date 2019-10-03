using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelloPage : ContentPage
    {
        public HelloPage()
        {
            InitializeComponent();
        }

        private void BtnHello_Clicked(object sender, EventArgs e)
        {
            String txtUserName = txtName.Text;
            DisplayAlert("Chào", "Chào ban " + txtUserName, "Thoát");
        }
    }
}