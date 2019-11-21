using System;
using System.Collections.Generic;
using System.Text;
using MobileApp.Models;
using SQLite;
using System.Linq;
namespace MobileApp.Helpers
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public Database()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.CreateTable<LoaiHoa>();
                    connection.CreateTable<Hoa>();
                }

            }
            catch (Exception)
            {

            }
        }

        public List<LoaiHoa> GetLoaiHoas()
        {

            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<LoaiHoa>().ToList();
                }

            }
            catch (Exception)
            {
                return null;
            }
        }


        public LoaiHoa GetLoaiHoaById(int MaLoai)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    var dsh = from lhs in connection.Table<LoaiHoa>().ToList()
                              where lhs.MaLoai == MaLoai
                              select lhs;

                    return dsh.FirstOrDefault();
                }

            }
            catch (Exception)
            {
                return null;
            }
        }


        public bool InsertLoaiHoa(LoaiHoa LoaiHoa)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(LoaiHoa);
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateLoaiHoa(LoaiHoa LoaiHoa)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Update(LoaiHoa);
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteLoaiHoa(LoaiHoa LoaiHoa)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Delete(LoaiHoa);
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
