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
	/// Логика взаимодействия для AddZakaz.xaml
	/// </summary>
	public partial class AddZakaz : Page
	{
        private ZakazViewModel _viewModel;
        private Zakaz _zakaz;
        public AddZakaz(ZakazViewModel viewModel, Zakaz zakaz = null)
		{
			InitializeComponent(); _viewModel = viewModel;
            _zakaz = zakaz ?? new Zakaz();

            if (_zakaz != null)
            {
                DataTextBox.Text = _zakaz.Data.ToString("yyyy-MM-dd");
                KaliTextBox.Text = _zakaz.Kolichestvo.ToString();
                ProductTextBox.Text = _zakaz.id_product.ToString();
                UserTextBox.Text = _zakaz.id_users.ToString();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _zakaz.Data = DateTime.Parse(DataTextBox.Text);
            _zakaz.Kolichestvo = int.Parse(KaliTextBox.Text);
            _zakaz.id_product = int.Parse(ProductTextBox.Text);
            _zakaz.id_users = int.Parse(UserTextBox.Text);

            if (_zakaz.id_zakaz == 0)
            {
                _viewModel.Zakaz.Add(_zakaz);
                _viewModel._ZakazService.AddZakaz(_zakaz);
            }
            else
            {
                _viewModel._ZakazService.EditZakaz(_zakaz);
            }

            NavigationService.GoBack();
        }
    }
}

