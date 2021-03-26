using Microsoft.AspNetCore.Mvc;
using RegisterUser.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegisterUser.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GenericController<T> : Controller where T : class
	{
		private IGenericService<T> _genericService;

		public GenericController(IGenericService<T> genericService)
		{
			_genericService = genericService;
		}
		// GET: api/<GenericController>
		[HttpGet]
		public List<T> Get()
		{
			return _genericService.GetAll();
		}

		[HttpGet("name/{name}")]
		public List<T> Get(string name)
		{
			return _genericService.GetByName(name);
		}

		[HttpGet("active/{status}")]
		public List<T> Get(bool status)
		{
			return _genericService.GetByStatus(status);
		}

		// GET api/<GenericController>/5
		[HttpGet("{id}")]
		public T Get(int id)	
		{
			return _genericService.GetById(id);
		}

		// POST api/<GenericController>
		[HttpPost]
		public List<T> Post([FromBody] T values)
		{
			return _genericService.Insert(values);
		}


		// DELETE api/<GenericController>/5
		[HttpDelete("{id}")]
		public List<T> Delete(int id)
		{
			return _genericService.Delete(id);
		}
	}
}
