using RegisterUser.IService;
using RegisterUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterUser.Service
{
	public class UserService : IGenericService<User>
	{
		List<User> _user = new List<User>();

		

		public UserService()
		{
			string dateInput = "Jan 1, 2009";
			var parsedDate = DateTime.Parse(dateInput);

			for (int i = 1; i <= 5; i++)
			{
				_user.Add(new User() {
					Id = i,
					Name = "User" + i,
					Birth = 1,
					Email = "User@email.com",
					Password = "1234",
					Sex = "M"
				}); ;
			}
		}
		public List<User> Delete(int id)
		{
			_user.RemoveAll(x => x.Id == id);
			return _user;
		}

		public List<User> GetAll()
		{
			return _user;
		}

		public User GetById(int id)
		{
			return _user.Where(x => x.Id == id).SingleOrDefault();
		}
		public List<User> GetByName(string name)
		{
			return _user.FindAll(x => x.Name == name);
		}
		public List<User> GetByStatus(bool status)
		{
			return _user.FindAll(x => x.Active == status);
		}

		public List<User> Insert(User item)
		{
			_user.Add(item);
			return _user;
		}
	}
}
