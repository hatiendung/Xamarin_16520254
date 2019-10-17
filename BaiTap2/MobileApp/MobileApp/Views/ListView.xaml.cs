using MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView : ContentPage
    {
        List<Flower> flowers;


        public ListView()
        {
            InitializeComponent();
            flowers = new List<Flower>();

            flowers.Add(new Flower { Name = "Đón xuân", Image = "donxuan.jpg", Price= 696969,Description= "Hoa cúc các màu: trắng, vàng, cam" });
            flowers.Add(new Flower { Name = "Hồn nhiên", Image = "honnhien.jpg", Price = 969696, Description = "Hoa cúc vàng, cam, lá măng" });
            flowers.Add(new Flower { Name = "Tím thủy chung", Image = "timthuychung.jpg", Price = 699698888, Description = "Hoa cúc tím" });
            listViewFlower.ItemsSource = flowers;
        }
    }
}