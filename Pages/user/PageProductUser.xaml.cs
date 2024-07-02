using ShopZooKalininWpf.Class;
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

namespace ShopZooKalininWpf.Pages.user
{
	/// <summary>
	/// Логика взаимодействия для PageProductUser.xaml
	/// </summary>
	public partial class PageProductUser : Page
	{
		private ProductViewModel _viewModel;
		public PageProductUser()
		{
			InitializeComponent();
			_viewModel = new ProductViewModel();
			DataContext = _viewModel;

		}
        private void ZakazProductButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageZakazUser());
        }
    }

	}

