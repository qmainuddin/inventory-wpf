﻿using System;
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

namespace ShopInventory.Pages.Stock.Categories.modals
{
    /// <summary>
    /// Interaction logic for AdvanceSearchBox.xaml
    /// </summary>
    public partial class AdvanceSearchBox : UserControl
    {
        public static readonly DependencyProperty ParentControlProperty = DependencyProperty.Register(
            "ParentControl", typeof(CategoryHome), typeof(AdvanceSearchBox), new PropertyMetadata(null));
        public CategoryHome ParentControl
        {
            get
            {
                return (CategoryHome)GetValue(ParentControlProperty);
            }
            set
            {
                SetValue(ParentControlProperty, value);
            }
        }
        public bool isOpened = false;

        private BrushConverter bc = new BrushConverter();
        public AdvanceSearchBox()
        {
            InitializeComponent();
        }
        private void OnHover_btn_close(object sender, MouseEventArgs e)
        {
            this.close_image.Source = new BitmapImage(new Uri(@"/Resources/b_close_hover.png", UriKind.Relative));
            this.close_btn.Background = (Brush)bc.ConvertFrom("#FF32a3cf");
            this.user_close_lbl.Foreground = new SolidColorBrush(Colors.White);
        }

        private void OnLeave_btn_close(object sender, MouseEventArgs e)
        {
            this.close_image.Source = new BitmapImage(new Uri(@"/Resources/b_close.png", UriKind.Relative));
            this.close_btn.Background = (Brush)bc.ConvertFrom("#FFF1ECEC");
            this.user_close_lbl.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void OnHover_btn_search(object sender, MouseEventArgs e)
        {
            this.search_image.Source = new BitmapImage(new Uri(@"/Resources/b_search.png", UriKind.Relative));
            this.search_btn.Background = (Brush)bc.ConvertFrom("#FF32a3cf");
            this.user_search_lbl.Foreground = new SolidColorBrush(Colors.White);
        }

        private void OnLeave_btn_search(object sender, MouseEventArgs e)
        {
            this.search_image.Source = new BitmapImage(new Uri(@"/Resources/b_search_leave.png", UriKind.Relative));
            this.search_btn.Background = (Brush)bc.ConvertFrom("#FFF1ECEC");
            this.user_search_lbl.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void OnHover_btn_clear(object sender, MouseEventArgs e)
        {
            this.reset_image.Source = new BitmapImage(new Uri(@"/Resources/b_reset_hover.png", UriKind.Relative));
            this.reset_btn.Background = (Brush)bc.ConvertFrom("#FF32a3cf");
            this.user_reset_lbl.Foreground = new SolidColorBrush(Colors.White);
        }
        private void OnLeave_btn_clear(object sender, MouseEventArgs e)
        {
            this.reset_image.Source = new BitmapImage(new Uri(@"/Resources/b_reset.png", UriKind.Relative));
            this.reset_btn.Background = (Brush)bc.ConvertFrom("#FFF1ECEC");
            this.user_reset_lbl.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void OnClick_btn_Close(object sender, RoutedEventArgs e)
        {
            try
            {
                this.HandleVisibilityOfAdvanceSearchBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reset_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {

        }
        public void HandleVisibilityOfAdvanceSearchBox()
        {
            if (!isOpened)
            {
                this.Visibility = Visibility.Visible;
                isOpened = true;
            }
            else
            {
                this.Visibility = Visibility.Hidden;
                isOpened = false;
            }
        }
    }
}
