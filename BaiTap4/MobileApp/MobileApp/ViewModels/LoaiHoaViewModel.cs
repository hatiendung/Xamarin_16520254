using MobileApp.Interface;
using MobileApp.Models;
using MobileApp.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class LoaiHoaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private LoaiHoa LoaiHoa;
        public ILoaiHoaRepository LoaiHoaRepository;

        public ICommand AddLoaiHoa { get; private set; }
        public ICommand UpdateLoaiHoa { get; private set; }

        public ICommand DeleteLoaiHoa { get; private set; }

        ObservableCollection<LoaiHoa> loaihoalist;

        public ObservableCollection<LoaiHoa> LoaiHoaList
        {
            get { return loaihoalist; }
            set
            {
                loaihoalist = value;
                RaisePropertyChanged("LoaiHoaList");
            }
        }

        public LoaiHoaViewModel()
        {
            LoaiHoaRepository = new LoaiHoaRepository();
            LoadLoaiHoa();
            AddLoaiHoa = new Command(Insert);

            UpdateLoaiHoa = new Command(Update, CanExe);
            DeleteLoaiHoa = new Command(Delete, CanExe);
            LoaiHoa = new LoaiHoa();
        }

        private void Delete()
        {
            LoaiHoaRepository.Delete(LoaiHoa);
            LoadLoaiHoa();
        }

        private bool CanExe()
        {
            if (LoaiHoa == null || LoaiHoa.MaLoai == 0)
            {
                return false;
            }
            return true;
        }

        private void Update()
        {
            LoaiHoaRepository.Update(LoaiHoa);
            LoadLoaiHoa();
        }

        private void LoadLoaiHoa()
        {
            LoaiHoaList = LoaiHoaRepository.GetLoaiHoas();
        }

        private void Insert()
        {
            LoaiHoaRepository.Insert(LoaiHoa);
            LoadLoaiHoa();
        }

        public void RaisePropertyChanged(string PropertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

    }
}
