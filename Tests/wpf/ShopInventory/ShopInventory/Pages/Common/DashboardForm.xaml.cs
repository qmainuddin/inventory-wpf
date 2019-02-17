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
using System.Windows.Threading;

namespace ShopInventory.Pages.Common
{
    /// <summary>
    /// Interaction logic for DashboardForm.xaml
    /// </summary>
    public partial class DashboardForm : UserControl
    {
        public MainWindow BaseWindow = null;
        public DashboardForm(MainWindow mw)
        {
            InitializeComponent();
            loadActivityPanel();
            if(this.BaseWindow == null)
            {
                BaseWindow = mw;
            }
        }
        
        private void loadActivityPanel()
        {
            this.LblDateSpan.Content = DateTime.Now.ToShortDateString();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            this.LblTimerSpan.Content = DateTime.Now.ToShortTimeString();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            this.LblTimerSpan.Content = DateTime.Now.ToLongTimeString();
        }

        private void onClickBilling(object sender, RoutedEventArgs e)
        {
            this.BaseWindow.GoToBilling();
        }

        private void onClickProducts(object sender, RoutedEventArgs e)
        {
            this.BaseWindow.ShowProducts();
        }
        
    }
}
