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
   public class ClientViewModel:BaseViewModel
    {
        private ObservableCollection<Client> allClients;
        public ObservableCollection<Client> AllClients { get
            {
                return allClients;
            }
            set
            {
                allClients = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllClients)));
            }
        }
    }
}
