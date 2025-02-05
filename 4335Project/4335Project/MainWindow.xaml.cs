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

namespace _4335Project
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

        private void Pavlova_4335_Click(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
            Hide();
        }


        private void Shafigullin_4335_Click(object sender, RoutedEventArgs e)
        {
            new Shafigullin().Show();
            Hide();
        }

        private void Zhelvakov_4335_Click(object sender, RoutedEventArgs e)
        {
            new Zhelvakov_4335().Show();
            Hide();
        }

        private void Yakimova_4335_Click(object sender, RoutedEventArgs e)
        {
            new _4335_Yakimova().Show();
            Hide();
        }

        private void Kurmanova_4335_Click(object sender, RoutedEventArgs e)
        {
            new Kurmanova_4335().Show();
            Hide();
        }

        private void Gappoev_4335_Click(object sender, RoutedEventArgs e)
        {
            new Gappoev_4335().Show();
            this.Close();
        }
    }
}
