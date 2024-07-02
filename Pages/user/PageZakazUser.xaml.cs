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
	/// Логика взаимодействия для PageZakazUser.xaml
	/// </summary>
	public partial class PageZakazUser : Page
	{
        internal ZakazViewModel _viewModel;
        public PageZakazUser()
		{
			InitializeComponent();
            _viewModel = new ZakazViewModel();
            DataContext = _viewModel;
        }

		private void AddProductButton_Click(object sender, RoutedEventArgs e)
		{
            NavigationService.Navigate(new AddZakaz(_viewModel));
        }
        private void UpdateProductButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.LoadZakaz();
        }
    }
}
