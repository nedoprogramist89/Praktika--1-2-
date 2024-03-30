using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Praktika_osnova_1.DataSet1TableAdapters;

namespace Praktika_osnova_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void NotebooksButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Page1());
        }
        private void CustomersButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Page2());
        }
        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Page3());
        }
        private void SalesButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Page4());
        }
    }
}
   
