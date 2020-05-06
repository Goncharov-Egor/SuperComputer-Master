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
using System.Collections;
using ClassLib;

namespace SuperComputer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public static AllDocuments ad;
        public static bool isFirst = true;
        LoadWindow lw = new LoadWindow();
        public MainWindow()
        {
            
            InitializeComponent();
            if (isFirst)
            {
                try
                {
                    Hide();
                    lw.Show();
                    lw.Qw(this);
                } catch (Exception ex)
                {
                    MessageBox.Show("Application files are probably damaged\nException messege:\n" + ex.Message);
                }
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                var tmp = from cmpReader in ad.computerReaders
                          where cmpReader.date == comboBox2.Text
                          select cmpReader;

                var tmp2 = tmp.ToList();

                ComputerReader cr = tmp2.Count > 0 ? tmp2[0] : new ComputerReader(FileParser.Parse(comboBox2.Text), comboBox2.Text);

                ad.computerReaders.Add(cr);
                List<Computer> ls = cr.getComputers(comboBox1.Text);
                dataGrid1.ItemsSource = ls;
            } catch(Exception ex)
            {
                MessageBox.Show("Application files are probably damaged\nException messege:\n" + ex.Message);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WikiWindow ww = new WikiWindow(this);
            ww.Show();
        }
    }
}
