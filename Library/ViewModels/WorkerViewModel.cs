using Library.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Library.ViewModels
{
   public class WorkerViewModel :BaseViewModel
    {
        private ObservableCollection<Worker> allWorkers;
        public ObservableCollection<Worker> AllWorkers
        {
            get
            {
                return allWorkers;
            }
            set {
                allWorkers = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllWorkers)));
            }
        }
    }
}
