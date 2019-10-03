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
    public partial class SumPage : ContentPage
    {
        public SumPage()
        {
            InitializeComponent();
        }

        private void BtnSum_Clicked(object sender, EventArgs e)
        {
            try
            {

                double sum = double.Parse(txtA.Text) + double.Parse(txtB.Text);
                txtSum.Text = sum.ToString();
            }
            catch (Exception)
            {
                DisplayAlert("Error","Bạn nhập vào có thể không phải là số","Thoát");
            }

        }

        private void BtnBackMainPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}