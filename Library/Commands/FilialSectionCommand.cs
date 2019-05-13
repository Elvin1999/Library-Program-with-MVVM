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
   public class FilialSectionCommand:ICommand
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
        public FilialSectionCommand(MainWindow MainWindow)
        {
            this.MainWindow = MainWindow;
        }
        public void Execute(object parameter)
        {
            FilialViewModel filialViewModel = new FilialViewModel();
            filialViewModel.AllFilials = new ObservableCollection<Filial>() {


            };

           

            FilialsWindow filialWindow = new FilialsWindow(filialViewModel);
            MainWindow.Close();
            filialWindow.ShowDialog();
        }
    }
}
