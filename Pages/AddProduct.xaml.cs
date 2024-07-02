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

namespace ShopZooKalininWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Page
    {
        private ProductViewModel _viewModel;
        public Products _product;
        public AddProduct(ProductViewModel viewModel, Products product = null)
        {
            InitializeComponent(); _viewModel = viewModel;
            _product = product ?? new Products();

            if (_product != null)
            {
                NameTextBox.Text = _product.Name;
                
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _product.Name = NameTextBox.Text;
            

            if (_product.Id_products == 0)
            {
                _viewModel.Products.Add(_product);
                _viewModel._productService.AddProduct(_product);
            }
            else
            {
                _viewModel._productService.EditProduct(_product);
            }

            NavigationService.GoBack();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}