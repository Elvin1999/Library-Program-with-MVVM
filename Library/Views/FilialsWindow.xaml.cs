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
    /// Interaction logic for FilialsWindow.xaml
    /// </summary>
    public partial class FilialsWindow : Window
    {
        public FilialViewModel FilialViewModel { get; set; }
        public FilialsWindow(FilialViewModel FilialViewModel)
        {
            InitializeComponent();
            this.FilialViewModel = FilialViewModel;
            DataContext = FilialViewModel; 
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
