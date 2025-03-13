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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            this.Hide();
            window.ShowDialog();
        }

      
        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            Window3 window = new Window3();
            this.Hide();
            window.ShowDialog();
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            this.Hide();
            window.ShowDialog();
        }
    }
}
