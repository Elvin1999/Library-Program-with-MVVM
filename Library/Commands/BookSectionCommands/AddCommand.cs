﻿using Library.Entities;
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
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public BookViewModel BookViewModel { get; set; }
        public AddCommand(BookViewModel BookViewModel)
        {
            this.BookViewModel = BookViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var curitem = BookViewModel.CurrentBook;
            if (curitem.Author != null && curitem.Filial != null && curitem.Genre != null &&
                curitem.Name != null && curitem.PageCount != 0 && curitem.SalePrice != 0)
            {
                var item = BookViewModel.AllBooks.FirstOrDefault(x => x.Id == BookViewModel.CurrentBook.Id);
                if (BookViewModel.AllBooks.Count != 0)
                {
                    int index = BookViewModel.AllBooks.Count - 1;
                    int newID = BookViewModel.AllBooks[index].Id + 1;
                    BookViewModel.CurrentBook.Id = newID;
                }
                if (item == null)
                {

                    BookViewModel.AllBooks.Add(BookViewModel.CurrentBook);

                    MessageBoxResult add = MessageBox.Show("Added");
                    BookViewModel.CurrentBook = new Book();
                    BookViewModel.SelectedBook = new Book();

                }
                else
                {
                    MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
                }
            }

        }
    }
}
