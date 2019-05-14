using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Library.Commands.WorkerSectionCommands
{
    public class UpdateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public WorkerViewModel WorkerViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public UpdateCommand(WorkerViewModel WorkerViewModel)
        {
            this.WorkerViewModel = WorkerViewModel;
        }
        public void Execute(object parameter)
        {

            var item = WorkerViewModel.AllWorkers.FirstOrDefault(x => x.Id == WorkerViewModel.CurrentWorker.Id);

            if (item != null)
            {
                var index = WorkerViewModel.AllWorkers.IndexOf(item);
                WorkerViewModel.AllWorkers[index] = WorkerViewModel.CurrentWorker;
                MessageBoxResult update = MessageBox.Show("updated");
                WorkerViewModel.CurrentWorker = new Worker();
                WorkerViewModel.SelectedWorker = new Worker();
            }

        }
    }
}
