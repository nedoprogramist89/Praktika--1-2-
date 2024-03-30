using Praktika_osnova_1.DataSet1TableAdapters;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Praktika_osnova_1.DataSet1TableAdapters;

namespace Praktika_osnova_1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        NotebooksTableAdapter notebooks = new NotebooksTableAdapter();
        public Page1()
        {
            InitializeComponent();
            Table1.ItemsSource = notebooks.GetData();
        }
    }
}
