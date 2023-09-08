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
    /// Interaction logic for Rent.xaml
    /// </summary>
    public partial class Rent : Window
    {
        double rent;
        public Rent()
        {
            InitializeComponent();
        }

        private void btnNxt_Click(object sender, RoutedEventArgs e)
        {
            VehicleOption vo = new VehicleOption();
            vo.Show();
        }

        private void btnBck_Click(object sender, RoutedEventArgs e)
        {
            Property p1 = new Property();
            p1.Show();
        }

        public void renting()
        {
            rent = Convert.ToDouble(tboxRental.Text);
            string Dis = "Your rental amount: R" + rent;
            DisplayReport D1 = new DisplayReport();
            D1.wans.Content = Dis.ToString();
            D1.ShowDialog();
        }

        private void btnRent_Click(object sender, RoutedEventArgs e)
        {
            renting();
        }
    }
}
