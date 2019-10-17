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

      

        private void BtnListView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListView());
        }

        private void BtnListViewGroup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewGroup());
        }
    }
}