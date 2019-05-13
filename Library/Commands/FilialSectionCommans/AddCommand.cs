using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Library.Commands.FilialSectionCommans
{
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public FilialViewModel FilialViewModel { get; set; }
        public AddCommand(FilialViewModel FilialViewModel)
        {
            this.FilialViewModel = FilialViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        
        public void Execute(object parameter)
        {

            if (FilialViewModel.AllFilials.Count == 0)
            {
                FilialViewModel.CurrentFilial.Id = 0;
            }
            else if (FilialViewModel.AllFilials.Count != 0)
            {
                int index = FilialViewModel.AllFilials.Count - 1;
                int newID = FilialViewModel.AllFilials[index].Id + 1;
                FilialViewModel.CurrentFilial.Id = newID;
                FilialViewModel.CurrentFilial.No = newID;

            }
            var item = FilialViewModel.AllFilials.FirstOrDefault(x => x.Id == FilialViewModel.CurrentFilial.Id);
            if (item == null)
            {

                FilialViewModel.AllFilials.Add(FilialViewModel.CurrentFilial);
                MessageBoxResult add = MessageBox.Show("Added");
                FilialViewModel.CurrentFilial = new Filial();
                FilialViewModel.SelectedFilial = new Filial();           
            }
            else
            {
                MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
            }
        }
    }
}
