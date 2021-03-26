using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterUser.Models
{
	public class User
	{
		public string status = "Sim";
		public int Id { get; set; }

		[Required(ErrorMessage = "Name Required!", AllowEmptyStrings = false)]
		[RegularExpression(@"^.{3,}$", ErrorMessage = "Minimum 3 characters required")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Birth Required!", AllowEmptyStrings = false)]
		public int Birth { get; set; }

		[Required(ErrorMessage = "Email Required!", AllowEmptyStrings = false)]
		public string Email { get; set; }
		public string Password { get; set; }

		[Required(ErrorMessage = "Sex Required!", AllowEmptyStrings = false)]
		public string Sex { get; set; }

		public bool Active { get; set; } = true;

		public User(string status, int id, string name, int birth, string email, string password, string sex, bool active)
		{
			this.status = status;
			Id = id;
			Name = name;
			Birth = birth;
			Email = email;
			Password = password;
			Sex = sex;
			Active = active;
		}

		public User()
		{
		}
	}
}
