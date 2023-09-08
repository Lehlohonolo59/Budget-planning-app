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
    /// Interaction logic for SavingsCal.xaml
    /// </summary>
    public partial class SavingsCal : Window
    {
        public SavingsCal()
        {
            InitializeComponent();
        }

        public void Cal()
        {
            //A = P*(1+r)^n.
            //P = money deposited; r= interest rate; n = period of saving 
            double MoneyDe = Convert.ToDouble(tboxAmount.Text);
            double IntRate = Convert.ToDouble(tboxInterest.Text) / 100;
            int Period = Convert.ToInt32(tboxPeriod.Text);
            string Rea = tboxReason.Text;
            double amoumt = MoneyDe * (1 + (IntRate * Period));
            double monthlySavings = (amoumt / Period) / 12;
           string Display =  "Money deposited: R" + MoneyDe + "\n"
                            + "The interest rate: " + IntRate + "\n"
                            + "The period of the savings: " + Period + " Years " + "\n"
                            + "The monthly amount you will pay: " + monthlySavings + "\n"
                            + "The reason for saving: " + Rea;
            DisplayReport D1 = new DisplayReport();
            D1.wans.Content = Display.ToString();
            D1.ShowDialog();
        }
        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            Cal();
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            string mass = "Thank you for using the application!!";
            MessageBox.Show(mass);
        }

        private void btnBck_Click(object sender, RoutedEventArgs e)
        {
            VehicleOption vo = new VehicleOption();
            vo.Show();
        }
    }
}
