using System;
namespace İnterfaceExample.Repository
{
	public interface IRepository<T>
	{
		void Add(T entity);

		void Delete(int id);

		T getValue(int id);

		void Update(T entity);

		List<T> GetAll();
	}
}

