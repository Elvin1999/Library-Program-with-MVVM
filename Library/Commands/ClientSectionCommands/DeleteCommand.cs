using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library.Commands.ClientSectionCommands
{
   public class DeleteCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ClientViewModel ClientViewModel { get; set; }
        public DeleteCommand(ClientViewModel ClientViewModel)
        {
            this.ClientViewModel = ClientViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            var item = ClientViewModel.SelectedClient;
            ClientViewModel.AllClients.Remove(item);
            ClientViewModel.SelectedClient = new Client();
        }
    }
}
