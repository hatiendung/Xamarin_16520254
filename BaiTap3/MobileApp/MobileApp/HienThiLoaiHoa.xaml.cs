using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HienThiLoaiHoa : ContentPage
    {
        Database database;
        List<LoaiHoa> loaiHoas;
        public HienThiLoaiHoa()
        {
            InitializeComponent();
            database = new Database();
            loaiHoas = database.GetAllLoaiHoa();
            listLoaiHoa.ItemsSource = loaiHoas;
        }

        private void ListLoaiHoa_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            LoaiHoa loaiHoa = (LoaiHoa)e.SelectedItem;
            Navigation.PushAsync(new HienThiHoaTheoLoai(loaiHoa));
        }
    }
}