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

namespace SuperComputer
{
    /// <summary>
    /// Логика взаимодействия для WikiWindow.xaml
    /// </summary>
    public partial class WikiWindow : Window
    {
        MainWindow mw;
        public WikiWindow(MainWindow mw)
        {
            this.mw = mw;
            mw.Hide();
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
            mw.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
