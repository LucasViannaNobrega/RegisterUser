using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegisterUser.IService;
using RegisterUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterUser.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : GenericController<User>
	{
		public UsersController(IGenericService<User> genericService) : base(genericService)
		{

		}
	}
}
