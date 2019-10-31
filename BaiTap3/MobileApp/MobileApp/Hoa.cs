using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace MobileApp
{
    public class Hoa
    {
        [PrimaryKey, AutoIncrement]
        public int MaHoa { get; set; }
        public int MaLoai { get; set; }
        public string TenHoa { get; set; }
        public string Hinh { get; set; }
        public string MoTa { get; set; }
        public double DonGia { get; set; }
    }
}
