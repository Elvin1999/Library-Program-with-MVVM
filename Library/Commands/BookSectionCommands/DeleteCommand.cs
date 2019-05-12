using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library.Commands.BookSectionCommands
{
    public class DeleteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public BookViewModel BookViewModel { get; set; }
        public DeleteCommand(BookViewModel BookViewModel)
        {
            this.BookViewModel = BookViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            var item = BookViewModel.SelectedBook;
            BookViewModel.AllBooks.Remove(item);
            BookViewModel.SelectedBook = new Book();
        }
    }
}
