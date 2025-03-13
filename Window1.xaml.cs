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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

       

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            Window5 window = new Window5();
            this.Hide();
            window.ShowDialog();
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            Window4 window = new Window4();
            this.Hide();
            window.ShowDialog();
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            Window8 window = new Window8();
            this.Hide();
            window.ShowDialog();
        }
    }
}
