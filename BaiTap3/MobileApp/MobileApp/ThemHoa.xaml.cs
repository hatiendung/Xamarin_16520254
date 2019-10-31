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
    public partial class ThemHoa : ContentPage
    {
        Database database;
        List<LoaiHoa> loaiHoas;
        public ThemHoa()
        {
            InitializeComponent();
            database = new Database();
            loaiHoas = database.GetAllLoaiHoa();
            listLoaiHoa.ItemsSource = loaiHoas;
        }

        private void BtnThemHoa_Clicked(object sender, EventArgs e)
        {
            string tenHoa = listLoaiHoa.Items[listLoaiHoa.SelectedIndex];
            int maLH = GetMaLoaiHoa(loaiHoas, tenHoa);
            double donGia = 0;
            try
            {
              donGia =   Double.Parse(txtGiaBan.Text);
                Hoa hoa = new Hoa { MaLoai = maLH, TenHoa = txtTenHoa.Text, Hinh = txtHinh.Text, DonGia = donGia, MoTa = txtMoTa.Text };
                if (database.InsertHoa(hoa) == true)
                {
                    DisplayAlert("Thông Báo", "Thêm hoa thành công", "OK");

                }
                else
                {
                    DisplayAlert("Thông Báo", "Thêm hoa thất bại", "Cancel");

                }
            }
            catch(Exception)
            {
                DisplayAlert("Thông Báo", "Đơn giá không phải là number", "Cancel");

            }
            
        }

        private int GetMaLoaiHoa(List<LoaiHoa> loaiHoas, string tenHoa)
        {
            foreach (LoaiHoa lh in loaiHoas)
            {
                if (lh.TenLoai.Equals(tenHoa))
                {
                    return lh.MaLoai;
                }
            }
            return -1;
        }

        private void BtnXoaHoa_Clicked(object sender, EventArgs e)
        {
            txtGiaBan.Text = null;
            txtHinh.Text = null;
            txtMoTa.Text = null;
            txtTenHoa.Text = null;
            listLoaiHoa.SelectedItem = null;
        }



    }
}