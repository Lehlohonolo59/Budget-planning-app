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
    /// Interaction logic for VehicleOption.xaml
    /// </summary>
    public partial class VehicleOption : Window
    {
        public VehicleOption()
        {
            InitializeComponent();
        }

        private void btnPurVehicle_Click(object sender, RoutedEventArgs e)
        {
            Vehicle v = new Vehicle();
            v.Show();
        }

        private void btnNxt_Click(object sender, RoutedEventArgs e)
        {
            SavingsCal SC = new SavingsCal();
            SC.Show();
        }
    }
}
