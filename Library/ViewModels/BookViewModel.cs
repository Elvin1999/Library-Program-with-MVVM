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
    }
}
