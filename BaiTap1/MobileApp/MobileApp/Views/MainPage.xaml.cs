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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void HelloPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HelloPage());
        }

        private void SumPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SumPage());
        }

        private void LoginPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void GridLayoutPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalculatorPage());
        }

        private void AbsoluteLayoutPage_Clicked(object sender, EventArgs e)
        {

        }

        private void StackLayoutPage_Clicked(object sender, EventArgs e)
        {

        }
    }
}