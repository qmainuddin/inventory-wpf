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

namespace ShopInventory.Pages.Billing
{
    /// <summary>
    /// Interaction logic for BillingPage.xaml
    /// </summary>
    public partial class BillingPage : UserControl
    {
        public MainWindow RootWindow = null;
        public BillingPage(MainWindow mw)
        {
            InitializeComponent();
            if(RootWindow == null)
            {
                RootWindow = mw;
            }
            this.productList.Content = new Stock.Products.ProductHome(RootWindow);
        }
    }
}
