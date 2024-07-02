using ShopZooKalininWpf.Class.Papka.ViewModels;
using ShopZooKalininWpf.Pages.Admin;
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

namespace ShopZooKalininWpf.Pages.Maneger
{
	/// <summary>
	/// Логика взаимодействия для PageProducManeger.xaml
	/// </summary>
	public partial class PageProducManeger : Page
	{
        private ProductViewModel _viewModel;
        public PageProducManeger()
		{
			InitializeComponent();
            _viewModel = new ProductViewModel();
            DataContext = _viewModel;
        }



        private void UpdateProductButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.LoadProducts();
        }

        private void ZakazProductButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageZakazManeger());
        }
    }
}
