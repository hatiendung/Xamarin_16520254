using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;
using System.Linq;
namespace MobileApp
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    //tạo 2 bang
                    connection.CreateTable<LoaiHoa>();
                    connection.CreateTable<Hoa>();
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        internal List<Hoa> GetHoaTheoLoai(int maLH)
        {

            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    var listHoa = from dsh in connection.Table<Hoa>().ToList()
                                  where dsh.MaHoa == maLH
                                  select dsh;
                    return listHoa.ToList();
                }
            }
            catch (SQLiteException)
            {

                return null;
            }
        }

        internal List<LoaiHoa> GetAllLoaiHoa()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<LoaiHoa>().ToList();
                }
            }
            catch (SQLiteException)
            {

                return null;
            }


        }

        internal Boolean InsertHoa(Hoa hoa)
        {
            try
            {
                using (var connection = new
                SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(hoa);
                    return true;
                }
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        public bool InsertLoaiHoa(LoaiHoa loaiHoa)
        {
            try
            {
                using (var connection = new
                SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(loaiHoa);
                    return true;
                }
            }
            catch (SQLiteException)
            {
                return false;
            }
        }
    }
}
