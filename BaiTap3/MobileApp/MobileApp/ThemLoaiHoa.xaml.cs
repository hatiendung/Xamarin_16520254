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
    public partial class ThemLoaiHoa : ContentPage
    {
        public ThemLoaiHoa()
        {
            InitializeComponent();
        }

        private void BtnGhi_Clicked(object sender, EventArgs e)
        {
            Database database = new Database();
            LoaiHoa loaiHoa = new LoaiHoa { TenLoai = txtTenLoaiHoa.Text };
            if(database.InsertLoaiHoa(loaiHoa) == true)
            {
                DisplayAlert("Thông Báo", "Thêm loại hoa thành công", "OK");

            }
            else
            {
                DisplayAlert("Thông Báo", "Thêm loại hoa thất bại", "Cancel");

            }
        }
    }
}