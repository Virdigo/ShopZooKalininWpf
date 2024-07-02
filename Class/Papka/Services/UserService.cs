using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopZooKalininWpf.Class.Papka.Services
{
	public class UserService
	{
		public Users Authenticate(string username, int password)
		{
			using (var context = new ShopZooKalininEntities1())
			{
				return context.Users.FirstOrDefault(u => u.Login == username && u.Password == password);
			}
		}
	}
}
