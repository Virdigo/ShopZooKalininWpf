using ShopZooKalininWpf.Class.Papka.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopZooKalininWpf.Class.Papka.ViewModels
{
	internal class LoginViewModel : BaseViewModel
	{
		private UserService _userService;
		public string Username { get; set; }
		public int Password { get; set; }
		public Users AuthenticatedUser { get; private set; }

		public LoginViewModel()
		{
			_userService = new UserService();
		}

		public bool Authenticate()
		{
			AuthenticatedUser = _userService.Authenticate(Username, Password);
			return AuthenticatedUser != null;
		}
	}
}
