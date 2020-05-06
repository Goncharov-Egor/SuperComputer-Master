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
    /// Логика взаимодействия для LoadWindow.xaml
    /// </summary>
    public partial class LoadWindow : Window
    {
        public LoadWindow()
        {
            InitializeComponent();
        }

        public void Qw(MainWindow mainWindow)
        {
            MainWindow.isFirst = false;
            MainWindow mw = new MainWindow();
            
            MainWindow.ad = new ClassLib.AllDocuments();

            Close();
            mw.Show();
        }
    }
}
