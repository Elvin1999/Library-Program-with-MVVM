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
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            BookViewModel bookViewModel = new BookViewModel();
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
            bookWindow.ShowDialog();

        }
    }
}
