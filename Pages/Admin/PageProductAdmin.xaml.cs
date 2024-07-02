using ShopZooKalininWpf.Class.Papka.ViewModels;
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

namespace ShopZooKalininWpf.Pages.Admin
{
	/// <summary>
	/// Логика взаимодействия для PageProductAdmin.xaml
	/// </summary>
	public partial class PageProductAdmin : Page
	{
        private ProductViewModel _viewModel;
        public PageProductAdmin()
		{
			InitializeComponent();
            _viewModel = new ProductViewModel();
            DataContext = _viewModel;
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProduct(_viewModel));
        }

        private void EditProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProductAdminListView.SelectedItem is Products selectedProduct)
            {
                NavigationService.Navigate(new AddProduct(_viewModel, selectedProduct));
            }
        }

        private void DeleteProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProductAdminListView.SelectedItem is Products selectedProduct)
            {
                _viewModel.Products.Remove(selectedProduct);
                _viewModel._productService.DeleteProduct(selectedProduct.Id_products);
            }
        }

        private void UpdateProductButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.LoadProducts();
        }

        private void ZakazProductButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageZakazAdmin());
        }
    }
}
