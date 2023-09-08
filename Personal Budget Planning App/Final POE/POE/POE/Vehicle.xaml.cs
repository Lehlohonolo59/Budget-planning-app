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
    /// Interaction logic for Vehicle.xaml
    /// </summary>
    public partial class Vehicle : Window
    {
        string ModelAndMakeOfCar;
        Double PurPrice, TotDeposit, InsuracePre, Rate, TotalMonthlyRepayment;
        int RepaymentMons;
        public Vehicle()
        {
            InitializeComponent();
        }

        private void btnDisReport_Click(object sender, RoutedEventArgs e)
        {
            purchase();
        }

        private void btnBck_Click(object sender, RoutedEventArgs e)
        {
            VehicleOption vo1 = new VehicleOption();
            vo1.Show();
        }

        private void btnNxt_Click(object sender, RoutedEventArgs e)
        {
            SavingsCal SC = new SavingsCal();
            SC.Show();
        }

        public void purchase()
        {
            ModelAndMakeOfCar = tboxModelAndMakeOfCar.Text;
            PurPrice = Convert.ToDouble(tboxPurPriceOfCar.Text);
            TotDeposit = Convert.ToDouble(tboxDepositV.Text);
            Rate = Convert.ToDouble(tboxInterest.Text);
            InsuracePre = Convert.ToDouble(tboxInsurace.Text);
            RepaymentMons = 60;
            //A = P(1 + in)
            //A A amount; P = PurPrice: i = Rate; n = RepaymentMons
            double amount = (TotDeposit - PurPrice * (1 + Rate * RepaymentMons) ) + InsuracePre;
            TotalMonthlyRepayment = amount / RepaymentMons;
            string Display = "Model And Make Of Car: " + ModelAndMakeOfCar + "\n"
                             + "Purchase Price Of Car: R" + PurPrice + "\n"
                             + "Total deposit: R" + TotDeposit + "\n"
                             + "Interest rate: " + Rate + "\n"
                             + "Insurace Premium: R" + InsuracePre + "\n"
                             + "The total monthly repayments: R" + TotalMonthlyRepayment;
            DisplayReport D1 = new DisplayReport();
            D1.wans.Content = Display.ToString();
            D1.ShowDialog();
        }



    }
}
