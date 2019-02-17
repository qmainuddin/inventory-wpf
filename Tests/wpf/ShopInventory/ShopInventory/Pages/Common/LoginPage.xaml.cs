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

namespace ShopInventory.Pages.Common
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : UserControl
    {
        public InitialPage RootPage = null;
        public LoginPage(InitialPage rootPage)
        {
            InitializeComponent();
            if (this.RootPage == null)
            {
                this.RootPage = rootPage;
                //Utils.Util.RootPage = rootPage;
            }
        }
        private void TextBoxUserIdChangeHandler(object sender, TextChangedEventArgs e)
        {

        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

        }

        private void PasswordChangedHandler(object sender, RoutedEventArgs e)
        {

        }
        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            //this.RootPage.login_loadingCanvas.Visibility = Visibility.Visible;
            //if (!uiThreadWorker.IsBusy)
            //{
            //    uiThreadWorker.RunWorkerAsync();
            //}
            //DoSomething();
            new MainWindow().Show();
            this.RootPage.Close();
        }
    }
}
