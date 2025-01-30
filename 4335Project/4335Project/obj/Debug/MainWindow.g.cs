using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace _4335Project
{
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Window, IComponentConnector
    {
        internal Button Pavlova_4335;
        internal Button Shafigullin_4335;
        internal Button Yakimova_4335;
        internal Button Zhelvakov_4335;
        internal Button Kurmanova_4335;

        private bool _contentLoaded;

        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            Uri resourceLocater = new Uri("/4335Project;component/mainwindow.xaml", UriKind.Relative);
            Application.LoadComponent(this, resourceLocater);
        }

        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Pavlova_4335 = (Button)target;
                    this.Pavlova_4335.Click += new RoutedEventHandler(this.Pavlova_4335_Click);
                    return;
                case 2:
                    this.Shafigullin_4335 = (Button)target;
                    this.Shafigullin_4335.Click += new RoutedEventHandler(this.Shafigullin_4335_Click);
                    return;
                case 3:
                    this.Yakimova_4335 = (Button)target;
                    this.Yakimova_4335.Click += new RoutedEventHandler(this.Yakimova_4335_Click);
                    return;
                case 4:
                    this.Zhelvakov_4335 = (Button)target;
                    this.Zhelvakov_4335.Click += new RoutedEventHandler(this.Zhelvakov_4335_Click);
                    return;
                case 5:
                    this.Kurmanova_4335 = (Button)target;
                    this.Kurmanova_4335.Click += new RoutedEventHandler(this.Kurmanova_4335_Click);
                    return;
            }
            _contentLoaded = true;
        }
    }
}
