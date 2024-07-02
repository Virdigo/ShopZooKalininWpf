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
	/// Логика взаимодействия для PageZakazAdmin.xaml
	/// </summary>
	public partial class PageZakazAdmin : Page
	{
        internal ZakazViewModel _viewModel;
        public PageZakazAdmin()
		{
			InitializeComponent();
            _viewModel = new ZakazViewModel();
            DataContext = _viewModel;
        }

		private void EditProductButton_Click(object sender, RoutedEventArgs e)
		{
            if (ZakazAdminListView.SelectedItem is Zakaz selectedZakaz)
            {
                NavigationService.Navigate(new AddZakaz(_viewModel, selectedZakaz));
            }
        }

		private void DeleteProductButton_Click(object sender, RoutedEventArgs e)
		{
            if (ZakazAdminListView.SelectedItem is Zakaz selectedZakaz)
            {
                _viewModel.Zakaz.Remove(selectedZakaz);
                _viewModel._ZakazService.DeleteZakaz(selectedZakaz.id_zakaz);
            }
        }

        private void UpdateProductButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.LoadZakaz();
        }
    }
}
