﻿using Library.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModels
{
   public class MainViewModel:BaseViewModel
    {
        public MainWindow MainWindow { get; set; }
        public MainViewModel(MainWindow MainWindow)
        {
            this.MainWindow = MainWindow;
        }
        public BookSectionCommand BookSectionCommand => new BookSectionCommand(MainWindow);
    }
}
