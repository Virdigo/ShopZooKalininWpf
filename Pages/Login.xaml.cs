using ShopZooKalininWpf.Class.Papka.ViewModels;
using ShopZooKalininWpf.Pages.user;
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
	/// Логика взаимодействия для Login.xaml
	/// </summary>
	public partial class Login : Page
	{
		private LoginViewModel _viewModel;
		public Login()
		{
			InitializeComponent();
			_viewModel = new LoginViewModel();
			DataContext = _viewModel;
		}

		private void LoginButton_Click(object sender, RoutedEventArgs e)
		{
			_viewModel.Username = UsernameTextBox.Text;
			_viewModel.Password = int.Parse(PasswordBox.Text);

			if (_viewModel.Authenticate())
			{
				var mainWindow = (MainWindow)Application.Current.MainWindow;
				mainWindow.NavigateToHomePage(_viewModel.AuthenticatedUser);
			}
			else
			{
				MessageBox.Show("Не правильно");
			}

		}
		private void VhodClick(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new PageProductUser());
		}
	}
}

		


