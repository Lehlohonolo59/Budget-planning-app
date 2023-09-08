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

namespace POE
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

        private void btnNxt_Click(object sender, RoutedEventArgs e)
        {
            Property p1 = new Property();
            p1.Show();
        }

        public void Exp()
        {
            double Income = Convert.ToDouble(tboxIncome.Text);
            double Tax = Convert.ToDouble(tboxTax.Text);
            double[] exp = new double[5];
            exp[0] = Convert.ToDouble(tbox_Groc.Text);
            exp[1] = Convert.ToDouble(tbox_WAndL.Text);
            exp[2] = Convert.ToDouble(tbox_Trav.Text);
            exp[3] = Convert.ToDouble(tbox_CellAndTele.Text);
            exp[4] = Convert.ToDouble(tbox_OtherExp.Text);
            double CalOfTot = exp[0] + exp[1] + exp[2] + exp[3] + exp[4];
            double RemainingMoney = Income - Tax - CalOfTot;
            string dis = "Income R" + Income + "\n" + "Tax R" + Tax + "\n" + "Expenses :" + "\n" +
                "Grocery : R" + exp[0] + "\n" + "Water And Lights : R" + exp[1] +
                "\n" + "Travel(Including petrol) : R" + exp[2] +
                "\n" + "Cellphone And Telephone : R" + exp[3] +
               "\n" + "other cost : R" + exp[4] +
               "\n" + "Total Cost of Expenses: R" + CalOfTot +
               "\n" + "Remaining amount after deductions: R" + RemainingMoney;
            DisplayReport D1 = new DisplayReport();
            D1.wans.Content = dis.ToString();
            D1.ShowDialog();
        }

        private void btnExp_Click(object sender, RoutedEventArgs e)
        {
            Exp();
        }
    }
}
