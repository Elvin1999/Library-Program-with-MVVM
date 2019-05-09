using Library.ViewModels;
using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Library.Commands
{
   public class BookSectionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

       
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            BookViewModel bookViewModel = new BookViewModel();
            BooksWindow bookWindow = new BooksWindow(bookViewModel);
            bookWindow.ShowDialog();

        }
    }
}
