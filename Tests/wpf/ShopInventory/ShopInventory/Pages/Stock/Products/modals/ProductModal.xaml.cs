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

namespace ShopInventory.Pages.Stock.Products.modals
{
    /// <summary>
    /// Interaction logic for ProductModal.xaml
    /// </summary>
    public partial class ProductModal : UserControl
    {
        public Pages.Common.ModalContainer Container = null;
        public ProductModal()
        {
            InitializeComponent();
            Container = Pages.Common.ModalContainer.getInstance();
        }
        private void footerBtnSecond_Click(object sender, RoutedEventArgs e)
        {
            this.Container.CloseModal();
        }

        private void OnLeave_footerBtnSecond(object sender, MouseEventArgs e)
        {

        }

        private void OnHover_footerBtnSecond(object sender, MouseEventArgs e)
        {

        }

        private void footerBtnFirst_Click(object sender, RoutedEventArgs e)
        {
            this.Container.CloseModal();
        }

        private void OnLeave_footerBtnFirst(object sender, MouseEventArgs e)
        {

        }

        private void OnHover_footerBtnFirst(object sender, MouseEventArgs e)
        {

        }

        private void OnClose_btn_modal(object sender, MouseButtonEventArgs e)
        {
            this.Container.CloseModal();
        }

        private void ProductIDTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ProductNameTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void MRPTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MRPTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void DiscountComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DiscountComboBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
