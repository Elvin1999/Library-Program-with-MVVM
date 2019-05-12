using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Library.Entities;

namespace Library.ViewModels
{
    public class BookViewModel : BaseViewModel
    {
        private Book currentBook;
        public Book CurrentBook
        {
            get
            {
                return currentBook;
            }
            set
            {
                currentBook = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentBook)));
            }
        }
        private ObservableCollection<Book> allBooks;
        public ObservableCollection<Book> AllBooks
        {
            get
            {
                return allBooks;
            }
            set
            {
                allBooks = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllBooks)));
            }
        }
        private Book selectedBook;
        public Book SelectedBook
        {
            get
            {
                return selectedBook;
            }
            set
            {
                selectedBook = value;
                if (value != null)
                {
                    CurrentBook = SelectedBook.Clone();
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedBook)));
            }
        }
    }
}
