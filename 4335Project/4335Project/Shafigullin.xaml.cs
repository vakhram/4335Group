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

namespace _4335Project
{
    /// <summary>
    /// Логика взаимодействия для Shafigullin.xaml
    /// </summary>
    public partial class Shafigullin : Window
    {
        public Shafigullin()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Shafigullin Ramil 18 years old");
        }
    }
}
