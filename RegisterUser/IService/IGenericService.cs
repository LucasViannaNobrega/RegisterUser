using RegisterUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterUser.IService
{
	public interface IGenericService<T>
	{
		List<T> GetAll();
		T GetById(int id);
		List<T> GetByName(string name);
		List<T> GetByStatus(bool status);
		List<T> Insert(T item);
		List<T> Delete(int id);
	}
}
