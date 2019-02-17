using ShopInventory.Lib.Entity.ProductDetail;
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

namespace ShopInventory.Pages.Stock.Units
{
    /// <summary>
    /// Interaction logic for UnitHome.xaml
    /// </summary>
    public partial class UnitHome : UserControl
    {
        MainWindow MW = null;
        public UnitHome(MainWindow mw)
        {
            InitializeComponent();
            this.MW = mw;
            this.PrepareDataGrid();
        }
        public void PrepareDataGrid()
        {
            List<ProductEntity> productBeanList = new List<ProductEntity>();

            for (int i = 0; i <= 100; i++)
            {
                ProductEntity productBean = new ProductEntity();
                productBean.ID = i;
                productBean.ProductID = "Lux";
                productBean.ProductName = "Mainuddin";
                productBean.MRP = "200 BDT";
                productBean.Vat = "10%";
                productBean.Discount = "30%";
                productBeanList.Add(productBean);
            }
            System.Windows.Controls.DataGridTemplateColumn col = this.FindResource("DGTemplateActionColumn") as System.Windows.Controls.DataGridTemplateColumn;
            this.table_dataGrid.ClearValue(System.Windows.Controls.ItemsControl.ItemsSourceProperty);
            Type productEntity = typeof(Lib.Entity.ProductDetail.ProductEntity);
            int actionColumnIndex = productEntity.GetProperties().Length;
            col.DisplayIndex = actionColumnIndex;
            this.table_dataGrid.ItemsSource = productBeanList;
            this.table_dataGrid.Columns.Add(col);
        }
        private void showProductModal()
        {
            this.MW.PopupContainer.innerContents.Content = new Products.modals.ProductModal();
            this.MW.ShowModal();
        }
        private void OnClickAdvanceSearch(object sender, RoutedEventArgs e)
        {
            this.AdvanceSearchBox.HandleVisibilityOfAdvanceSearchBox();
        }

        private void BtnEdit_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void DGTemplateEdit_Click(object sender, RoutedEventArgs e)
        {
            this.showProductModal();
        }
        private void DGTemplateDelete_Click(object sender, RoutedEventArgs e)
        {
            //this.MW.ShowErrorMessage();
        }

        private void BtnDelete_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void dataGridView_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {

        }

        private void DataGrid_CopyingRowClipboardContent(object sender, DataGridRowClipboardEventArgs e)
        {

        }

        private void dataGrid_LayoutUpdated(object sender, EventArgs e)
        {

        }

        private void DataGrid_Sorting(object sender, DataGridSortingEventArgs e)
        {

        }

        private void OnHover_btn_create(object sender, MouseEventArgs e)
        {

        }

        private void OnLeave_btn_create(object sender, MouseEventArgs e)
        {

        }

        private void OnClick_Create(object sender, RoutedEventArgs e)
        {
            this.showProductModal();
        }
    }
}
