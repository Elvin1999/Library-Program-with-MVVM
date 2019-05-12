using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Library.Entities;
using Library.Commands.BookSectionCommands;

namespace Library.ViewModels
{
    public class BookViewModel : BaseViewModel
    {
        public List<Author> Authors { get; set; }
        public List<Filial> Filials { get; set; }
        public List<Genre> Genres { get; set; }
        public AddCommand AddCommand => new AddCommand(this);
        public UpdateCommand UpdateCommand => new UpdateCommand(this);
        public DeleteCommand DeleteCommand => new DeleteCommand();     
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
        public BookViewModel()
        {
            CurrentBook = new Book();
        }
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

        private Book selectedBook;
        public  Book SelectedBook
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
