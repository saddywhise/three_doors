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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

       

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            Window6 window = new Window6();
            this.Hide();
            window.ShowDialog();
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            Window7 window = new Window7();
            this.Hide();
            window.ShowDialog();
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            Window9 window = new Window9();
            this.Hide();
            window.ShowDialog();
        }
    }
}
