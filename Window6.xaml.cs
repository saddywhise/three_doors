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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

       

        private void Button_10_Click(object sender, RoutedEventArgs e)
        {
            Window10 window = new Window10();
            this.Hide();
            window.ShowDialog();
        }

        private void Button_11_Click(object sender, RoutedEventArgs e)
        {
            Window11 window = new Window11();
            this.Hide();
            window.ShowDialog();
        }

        private void Button_12_Click(object sender, RoutedEventArgs e)
        {
            Window12 window = new Window12();
            this.Hide();
            window.ShowDialog();
        }
    }
}
