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
    /// Interaction logic for Buying.xaml
    /// </summary>
    public partial class Buying : Window
    {
        double PurPrice, TotDeposit, IntRate, MonthlyRepayment;
        int RepaymentMons;
        public Buying()
        {
            InitializeComponent();
        }

        private void btnLoan_Click(object sender, RoutedEventArgs e)
        {
            Buy();
        }

        private void btnNxt_Click(object sender, RoutedEventArgs e)
        {
            VehicleOption v1 = new VehicleOption();
            v1.Show();
        }


        private void btnBck_Click(object sender, RoutedEventArgs e)
        {
            Property p1 = new Property();
            p1.Show();
        }

        public void Buy()
        {
            PurPrice = Convert.ToDouble(tboxPurPrice.Text);
            TotDeposit = Convert.ToDouble(tboxDeposit.Text);
            IntRate = Convert.ToDouble(tboxInterest.Text) / 100;
            RepaymentMons = Convert.ToInt32(tboxRepay.Text);
            //A = P(1 + in)
            //A = amount; P = PurPrice; i = rate; n = RepaymentMons
            double amount = PurPrice * (1 + IntRate * RepaymentMons);
            MonthlyRepayment = TotDeposit - (amount / RepaymentMons);
            string display = "Purchase Price: R" + PurPrice + "\n"
                             + "Total Deposit: R" + TotDeposit + "\n"
                             + "Interest Rate: " + IntRate + "\n"
                             + "The period: " + RepaymentMons + "\n"
                             + "Monthly repayment: " + MonthlyRepayment;
            DisplayReport D1 = new DisplayReport();
            D1.wans.Content = display.ToString();
            D1.ShowDialog();
        }
    }
}
