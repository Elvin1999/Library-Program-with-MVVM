﻿using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library.Views
{
    /// <summary>
    /// Interaction logic for BooksWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window
    {
        public BookViewModel BookViewModel { get; set; }
        public BooksWindow(BookViewModel BookViewModel)
        {
            InitializeComponent();
            this.BookViewModel = BookViewModel;
            DataContext = BookViewModel;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow mainWindow = new MainWindow();
            MainViewModel mainView = new MainViewModel(mainWindow);
            mainView.MainWindow.Show();
            this.Close();
        }
    }
}
