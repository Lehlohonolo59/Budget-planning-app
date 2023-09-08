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

namespace POE
{
    /// <summary>
    /// Interaction logic for Property.xaml
    /// </summary>
    public partial class Property : Window
    {
        public Property()
        {
            InitializeComponent();
        }

        private void btnRent_Click(object sender, RoutedEventArgs e)
        {
            Rent r1 = new Rent();
            r1.Show();
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            Buying b1 = new Buying();
            b1.Show();
        }

        private void btnBck_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
        }
    }
}
