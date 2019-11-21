using MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MobileApp.Interface
{
    public interface ILoaiHoaRepository
    {
        ObservableCollection<LoaiHoa> GetLoaiHoas();

        LoaiHoa GetLoaiHoaById(int MaLoai);

        bool Insert(LoaiHoa LoaiHoa);
        bool Delete(LoaiHoa LoaiHoa);

        bool Update(LoaiHoa LoaiHoa);
    }
}
