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
    public partial class HienThiHoaTheoLoai : ContentPage
    {
        int maLH;
        public HienThiHoaTheoLoai()
        {
            
            InitializeComponent();
            Database database = new Database();
            List<Hoa> hoas;
            Console.WriteLine(this.maLH);
            hoas = database.GetHoaTheoLoai(maLH);
            foreach (Hoa h in hoas)
            {
                Console.WriteLine(h);
            }

        }

        public HienThiHoaTheoLoai(LoaiHoa loaiHoa)
        {
            this.maLH = loaiHoa.MaLoai;
        }
    }
}