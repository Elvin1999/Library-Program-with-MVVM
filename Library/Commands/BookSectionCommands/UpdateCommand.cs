using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Library.Commands.BookSectionCommands
{
    public class UpdateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public BookViewModel BookViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public UpdateCommand(BookViewModel BookViewModel)
        {
            this.BookViewModel = BookViewModel;
        }
        public void Execute(object parameter)
        {
            var item = BookViewModel.AllBooks.FirstOrDefault(x => x.Id == BookViewModel.CurrentBook.Id);

            if (item != null)
            {
                var index = BookViewModel.AllBooks.IndexOf(item);
                BookViewModel.AllBooks[index] = BookViewModel.CurrentBook;
                MessageBoxResult update = MessageBox.Show("updated");
                BookViewModel.CurrentBook = new Book();
                BookViewModel.SelectedBook = new Book();
            }
        }
    }
}
