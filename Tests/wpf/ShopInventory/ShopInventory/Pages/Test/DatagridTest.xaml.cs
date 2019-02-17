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

namespace ShopInventory.Pages.Test
{
    /// <summary>
    /// Interaction logic for DatagridTest.xaml
    /// </summary>
    public partial class DatagridTest : UserControl
    {
        public DatagridTest()
        {
            InitializeComponent();
        }
        public void addProductList()
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
    }
}
