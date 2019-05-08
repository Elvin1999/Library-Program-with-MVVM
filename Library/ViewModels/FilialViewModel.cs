using Library.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModels
{
    public class FilialViewModel : BaseViewModel
    {
        private ObservableCollection<Filial> allFilials;
        public ObservableCollection<Filial> AllFilials
        {
            get
            {
                return allFilials;
            }
            set
            {
                allFilials = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllFilials)));
            }
        }
    }
}
