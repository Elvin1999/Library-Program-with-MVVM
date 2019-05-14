using Library.Entities;
using Library.ViewModels;
using Library.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library.Commands
{
   public class ClientSectionCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;
        private int id = 0;
        private int no = 0;
        private int no2 = 0;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public MainWindow MainWindow { get; set; }
        public ClientSectionCommand(MainWindow MainWindow)
        {
            this.MainWindow = MainWindow;
        }
        public void Execute(object parameter)
        {
            ClientViewModel clientViewModel = new ClientViewModel();
            clientViewModel.AllClients = new ObservableCollection<Client>();



            ClientsWindow filialWindow = new ClientsWindow(clientViewModel);
            MainWindow.Close();
            filialWindow.ShowDialog();
        }
    }
}
