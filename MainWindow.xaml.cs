using ShopZooKalininWpf.Class;
using ShopZooKalininWpf.Pages;
using ShopZooKalininWpf.Pages.Admin;
using ShopZooKalininWpf.Pages.Maneger;
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

namespace ShopZooKalininWpf
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			MainFrame.Navigate(new Login());
		}
		public void NavigateToHomePage(Users user)
		{
			if (user.Role == "Admin")
			{
				MainFrame.Navigate(new PageProductAdmin());
			}
			else if (user.Role == "Maneger")
			{
				MainFrame.Navigate(new PageProducManeger());
			}
			else if (user.Role == "User")
			{
				MainFrame.Navigate(new PageProductUser()); 
			}
		}
	}
}
