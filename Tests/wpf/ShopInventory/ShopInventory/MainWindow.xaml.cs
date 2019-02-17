using ShopInventory.Pages.Billing;
using ShopInventory.Pages.Common;
using ShopInventory.Pages.Stock.Categories;
using ShopInventory.Pages.Stock.Products;
using ShopInventory.Pages.Test;
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

namespace ShopInventory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BrushConverter bc = new BrushConverter();
        private bool isHoverOn = false;
        public DashboardForm Dashboard = null;
        public PagingControl paging = null;
        public MainWindow()
        {
            InitializeComponent();
            this.MainBreadCrumb.RootWindow = this;
            this.MainBreadCrumb.setFirstBreadCrumb("Dashboard");
            Dashboard = new DashboardForm(this);
            this.bodyContainer.Content = Dashboard;

            //paging = new PagingControl();
            //this.bodyContainer.Content = paging;

            //this.bodyContainer.Content = new ProductHome(this);
            //this.bodyContainer.Content = new AdvanceSearchBox();
        }
        private void OnClick_Billing(object sender, RoutedEventArgs e)
        {
            //this.MainBreadCrumb.setOtherTwoBreadCrumb("Billing", "Billing Info");
            GoToBilling();
        }

        private void ClickOnProducts(object sender, RoutedEventArgs e)
        {
            ShowProducts();

        }
        private void TxtLogout_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!isHoverOn)
            {
                startHoverOnLogoutBtn();
            }
        }

        private void img_logout_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!isHoverOn)
            {
                startHoverOnLogoutBtn();
            }
        }
        private void TxtLogout_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isHoverOn)
            {
                stopHoverOnLogoutBtn();
            }
        }
        private void img_logout_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isHoverOn)
            {
                stopHoverOnLogoutBtn();
            }
        }
        private void startHoverOnLogoutBtn()
        {
            this.isHoverOn = true;
            //this.img_logout.Height = 20;
            //this.TxtLogout.Foreground = new SolidColorBrush(Colors.Red);
        }
        private void stopHoverOnLogoutBtn()
        {
            this.isHoverOn = false;
            //this.img_logout.Height = 15;
            //this.TxtLogout.Foreground = (Brush)bc.ConvertFrom("#0e526a");
        }
        public void ShowDashboard()
        {
            this.MainBreadCrumb.setFirstBreadCrumb("Dashboard");
            this.bodyContainer.Content = this.Dashboard;
        }
        public void ShowProducts()
        {
            this.MainBreadCrumb.setOtherTwoBreadCrumb("Stock", "Products");
            this.bodyContainer.Content = new ProductHome(this);
        }
        public void ShowCategories()
        {
            this.MainBreadCrumb.setOtherTwoBreadCrumb("Stock", "Categories");
            this.bodyContainer.Content = new CategoryHome(this);
        }
        public void GoToBilling()
        {
            this.MainBreadCrumb.setOtherTwoBreadCrumb("Billing", "Product Billing");
            this.bodyContainer.Content = new BillingPage(this);
        }
        public void ShowModal()
        {
            Utils.Util.addWipeDownAnnimation(this.PopupContainer, (this.ActualHeight + 1000));
            Utils.Util.LoadingPage = this.loadingCanvas;
            this.loadingCanvas.Visibility = Visibility.Visible;
            this.PopupContainer.SetParent(this.mainBody);
            this.PopupContainer.ShowHandlerDialog();
        }
        public void logout()
        {
            new InitialPage().Show();
            this.Close();
        }

        private void clickOneLogoutBtn(object sender, MouseButtonEventArgs e)
        {
            logout();
        }

        private void ClickOnCategories(object sender, RoutedEventArgs e)
        {
            ShowCategories();
        }

        private void ClickOnUnits(object sender, RoutedEventArgs e)
        {

        }

        private void ClickOnBrands(object sender, RoutedEventArgs e)
        {

        }

        private void ClickOnSuppliers(object sender, RoutedEventArgs e)
        {

        }
    }
}
