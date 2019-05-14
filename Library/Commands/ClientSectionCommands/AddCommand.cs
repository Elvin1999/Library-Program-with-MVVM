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
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ClientViewModel ClientViewModel { get; set; }
        public AddCommand(ClientViewModel ClientViewModel)
        {
            this.ClientViewModel = ClientViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var curitem = ClientViewModel.CurrentClient;
            if (curitem.Name != null && curitem.PhoneNumber != null && curitem.Surname != null &&
                curitem.ConnectionDT != null)
            {
                if (ClientViewModel.AllClients.Count == 0)
                {
                    ClientViewModel.CurrentClient.Id = 0;
                }
                else if (ClientViewModel.AllClients.Count != 0)
                {
                    int index = ClientViewModel.AllClients.Count - 1;
                    int newID = ClientViewModel.AllClients[index].Id + 1;
                    ClientViewModel.CurrentClient.Id = newID;
                    ClientViewModel.CurrentClient.No = newID;
                }
                var item = ClientViewModel.AllClients.FirstOrDefault(x => x.Id == ClientViewModel.CurrentClient.Id);
                if (item == null)
                {

                    ClientViewModel.AllClients.Add(ClientViewModel.CurrentClient);
                    MessageBoxResult add = MessageBox.Show("Added");
                    ClientViewModel.CurrentClient = new Client();
                    ClientViewModel.SelectedClient = new Client();
                }
                else
                {
                    MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
                }
            }
            else
            {
                MessageBoxResult add = MessageBox.Show("Fill all of blanks");
            }

        }
    }
}
