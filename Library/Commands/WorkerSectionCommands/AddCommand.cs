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
   public class AddCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public WorkerViewModel WorkerViewModel { get; set; }
        public AddCommand(WorkerViewModel WorkerViewModel)
        {
            this.WorkerViewModel = WorkerViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var curitem = WorkerViewModel.CurrentWorker;
            if (curitem.Name != null && curitem.Surname != null)
            {

                if (WorkerViewModel.AllWorkers.Count == 0)
                {
                    WorkerViewModel.CurrentWorker.Id = 0;
                }
                else if (WorkerViewModel.AllWorkers.Count != 0)
                {
                    int index = WorkerViewModel.AllWorkers.Count - 1;
                    int newID = WorkerViewModel.AllWorkers[index].Id + 1;
                    WorkerViewModel.CurrentWorker.Id = newID;
                    WorkerViewModel.CurrentWorker.No = newID;
                }
                var item = WorkerViewModel.AllWorkers.FirstOrDefault(x => x.Id == WorkerViewModel.CurrentWorker.Id);
                if (item == null)
                {

                    WorkerViewModel.AllWorkers.Add(WorkerViewModel.CurrentWorker);
                    MessageBoxResult add = MessageBox.Show("Added");
                    WorkerViewModel.CurrentWorker = new Worker();
                    WorkerViewModel.SelectedWorker = new Worker();
                }
                else
                {
                    MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
                }
            }
            else
            {
                MessageBoxResult add = MessageBox.Show("Please fill name and surname blank");
            }
        }
    }
}
