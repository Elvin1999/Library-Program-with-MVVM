using Library.Commands.ClientSectionCommands;
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
        public AddCommand AddCommand => new AddCommand(this);
        public UpdateCommand UpdateCommand => new UpdateCommand(this);
        public DeleteCommand DeleteCommand => new DeleteCommand(this);
        private ObservableCollection<Client> allClients;
        public ObservableCollection<Client> AllClients
        {
            get
            {
                return allClients;
            }
            set
            {
                allClients = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllClients)));
            }
        }
        public ClientViewModel()
        {
            CurrentClient = new Client();
        }
        private Client currentClient;
        public Client CurrentClient
        {
            get
            {
                return currentClient;
            }
            set
            {
                currentClient = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentClient)));
            }
        }

        private Client selectedClient;
        public Client SelectedClient
        {
            get
            {
                return selectedClient;
            }
            set
            {
                selectedClient = value;
                if (value != null)
                {
                    CurrentClient = SelectedClient.Clone();
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedClient)));
            }
        }
    }
}
