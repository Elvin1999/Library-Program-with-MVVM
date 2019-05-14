using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Library.Commands.ClientSectionCommands
{
   public class UpdateCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ClientViewModel ClientViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public UpdateCommand(ClientViewModel ClientViewModel)
        {
            this.ClientViewModel = ClientViewModel;
        }
        public void Execute(object parameter)
        {

            var item = ClientViewModel.AllClients.FirstOrDefault(x => x.Id == ClientViewModel.CurrentClient.Id);

            if (item != null)
            {
                var index = ClientViewModel.AllClients.IndexOf(item);
                ClientViewModel.AllClients[index] = ClientViewModel.CurrentClient;
                MessageBoxResult update = MessageBox.Show("updated");
                ClientViewModel.CurrentClient = new Client();
                ClientViewModel.SelectedClient = new Client();
            }

        }
    }
}
