using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library.Commands.FilialSectionCommans
{
   public class DeleteCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public FilialViewModel FilialViewModel { get; set; }
        public DeleteCommand(FilialViewModel FilialViewModel)
        {
            this.FilialViewModel = FilialViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            var item = FilialViewModel.SelectedFilial;
            FilialViewModel.AllFilials.Remove(item);
            FilialViewModel.SelectedFilial = new Filial();
        }
    }
}
