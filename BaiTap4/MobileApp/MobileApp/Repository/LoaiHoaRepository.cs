using MobileApp.Helpers;
using MobileApp.Interface;
using MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MobileApp.Repository
{
    public class LoaiHoaRepository : ILoaiHoaRepository
    {
        Database database;

        public LoaiHoaRepository()
        {
            database = new Database();
        }


        public bool Delete(LoaiHoa LoaiHoa)
        {
            return database.DeleteLoaiHoa(LoaiHoa);
        }

        public LoaiHoa GetLoaiHoaById(int MaLoai)
        {
            return database.GetLoaiHoaById(MaLoai);
        }

        public ObservableCollection<LoaiHoa> GetLoaiHoas()
        {
            return new ObservableCollection<LoaiHoa>(database.GetLoaiHoas());
        }

        public bool Insert(LoaiHoa LoaiHoa)
        {
            return database.InsertLoaiHoa(LoaiHoa);
        }

        public bool Update(LoaiHoa LoaiHoa)
        {
            return database.UpdateLoaiHoa(LoaiHoa);
        }
    }
}
