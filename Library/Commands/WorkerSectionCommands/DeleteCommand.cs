using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library.Commands.WorkerSectionCommands
{
   public class DeleteCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public WorkerViewModel WorkerViewModel { get; set; }
        public DeleteCommand(WorkerViewModel WorkerViewModel)
        {
            this.WorkerViewModel = WorkerViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            var item = WorkerViewModel.SelectedWorker;
            WorkerViewModel.AllWorkers.Remove(item);
            WorkerViewModel.SelectedWorker = new Worker();
        }
    }
}
