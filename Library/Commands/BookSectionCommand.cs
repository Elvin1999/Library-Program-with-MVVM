using Library.Entities;
using Library.ViewModels;
using Library.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private int id = 0;
        private int no = 0;
        private int no2 = 0;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public MainWindow MainWindow { get; set; }
        public BookSectionCommand(MainWindow MainWindow)
        {
            this.MainWindow = MainWindow;
        }
        public void Execute(object parameter)
        {
            BookViewModel bookViewModel = new BookViewModel();
            bookViewModel.Filials = new List<Filial>()
            {
                new Filial()
                {
                    Id=++id,No=++no2,Name="Nizami Filiali",Address="Nizami Metrosunun Yani"
                },
                new Filial()
                {
                    Id=++id,No=++no2,Name="Sumqayit Filiali",Address="Asan Xidmetin Yani"
                },
                new Filial()
                {
                    Id=++id,No=++no2,Name="Gence Filiali",Address="Ehmed Recebli Kuchesi"
                }
            };no2 = 0;
            bookViewModel.Genres = new List<Genre>()
            {
                new Genre()
                {
                    Id=++id,No=++no2,Name="Drama"
                },
                 new Genre()
                {
                    Id=++id,No=++no2,Name="Love"
                },
                  new Genre()
                {
                    Id=++id,No=++no2,Name="Action"
                },
            };no2 = 0;
            bookViewModel.Authors = new List<Author>()
            {
                new Author()
                {
                    Id=++id,No=no2,Name="Michelle",Surname="Obama",PhoneNumber="+994515568594"
                },
                new Author()
                {
                    Id=++id,No=no2,Name="Victor",Surname="Huqo",PhoneNumber="+994558559671"
                },
                new Author()
                {
                    Id=++id,No=no2,Name="Elxan",Surname="Elatli",PhoneNumber="+994558795848"
                }
            };
            bookViewModel.AllBooks = new ObservableCollection<Entities.Book>()
            {
                new Book()
                {
                    Name="Becoming",Id=++id,No=++no, Author=new Author()
                    {
                        Id=++id,Name="Michelle",Surname="Obama",PhoneNumber="+994554548796",No=no
                    },
                    Filial=new Filial()
                    {
                        Id=++id,No=no,Name="Nizami_Filiali",Address="Caspian plazanin yani"
                    },
                    Genre=new Genre()
                    {
                        Id=++id,No=no,Name="Drama",
                    }
                    ,PageCount=450,
                    PurchasePrice=350.5,
                    SalePrice=4253.99
                },
                new Book()
                {
                    Name="Becoming",Id=++id,No=++no, Author=new Author()
                    {
                        Id=++id,Name="Michelle",Surname="Obama",PhoneNumber="+994554548796",No=no
                    },
                    Filial=new Filial()
                    {
                        Id=++id,No=no,Name="Nizami_Filiali",Address="Caspian plazanin yani"
                    },
                    Genre=new Genre()
                    {
                        Id=++id,No=no,Name="Drama",
                    }
                    ,PageCount=450,
                    PurchasePrice=350.5,
                    SalePrice=4253.99
                },
                new Book()
                {
                    Name="Becoming",Id=++id,No=++no, Author=new Author()
                    {
                        Id=++id,Name="Michelle",Surname="Obama",PhoneNumber="+994554548796",No=no
                    },
                    Filial=new Filial()
                    {
                        Id=++id,No=no,Name="Nizami_Filiali",Address="Caspian plazanin yani"
                    },
                    Genre=new Genre()
                    {
                        Id=++id,No=no,Name="Drama",
                    }
                    ,PageCount=450,
                    PurchasePrice=350.5,
                    SalePrice=4253.99
                },
                new Book()
                {
                    Name="Becoming",Id=++id,No=++no, Author=new Author()
                    {
                        Id=++id,Name="Michelle",Surname="Obama",PhoneNumber="+994554548796",No=no
                    },
                    Filial=new Filial()
                    {
                        Id=++id,No=no,Name="Nizami_Filiali",Address="Caspian plazanin yani"
                    },
                    Genre=new Genre()
                    {
                        Id=++id,No=no,Name="Drama",
                    }
                    ,PageCount=450,
                    PurchasePrice=350.5,
                    SalePrice=4253.99
                },
                new Book()
                {
                    Name="Becoming",Id=++id,No=++no, Author=new Author()
                    {
                        Id=++id,Name="Michelle",Surname="Obama",PhoneNumber="+994554548796",No=no
                    },
                    Filial=new Filial()
                    {
                        Id=++id,No=no,Name="Nizami_Filiali",Address="Caspian plazanin yani"
                    },
                    Genre=new Genre()
                    {
                        Id=++id,No=no,Name="Drama",
                    }
                    ,PageCount=450,
                    PurchasePrice=350.5,
                    SalePrice=4253.99
                },
                new Book()
                {
                    Name="Becoming",Id=++id,No=++no, Author=new Author()
                    {
                        Id=++id,Name="Michelle",Surname="Obama",PhoneNumber="+994554548796",No=no
                    },
                    Filial=new Filial()
                    {
                        Id=++id,No=no,Name="Nizami_Filiali",Address="Caspian plazanin yani"
                    },
                    Genre=new Genre()
                    {
                        Id=++id,No=no,Name="Drama",
                    }
                    ,PageCount=450,
                    PurchasePrice=350.5,
                    SalePrice=4253.99
                },

            };
            
            BooksWindow bookWindow = new BooksWindow(bookViewModel);
            MainWindow.Close();
            bookWindow.ShowDialog();
        }
    }
}
