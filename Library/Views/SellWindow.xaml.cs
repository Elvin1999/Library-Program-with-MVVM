using Library.ViewModels;
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
    /// Interaction logic for SellWindow.xaml
    /// </summary>
    public partial class SellWindow : Window
    {
        public SaleViewModel SaleViewModel { get; set; }
        public SellWindow(SaleViewModel SaleViewModel)
        {
            InitializeComponent();
            
            this.SaleViewModel = SaleViewModel;
            DataContext = SaleViewModel;
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

