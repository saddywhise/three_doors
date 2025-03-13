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
    /// Логика взаимодействия для Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        public Window12()
        {
            InitializeComponent();
        }

       

        private void Button_15_Click(object sender, RoutedEventArgs e)
        {
            Window15 window = new Window15();
            this.Hide();
            window.ShowDialog();
        }

        private void Button_14_Click(object sender, RoutedEventArgs e)
        {
            Window14 window = new Window14();
            this.Hide();
            window.ShowDialog();
        }

        private void Button_13_Click(object sender, RoutedEventArgs e)
        {
            Window13 window = new Window13();
            this.Hide();
            window.ShowDialog();
        }
    }
}
