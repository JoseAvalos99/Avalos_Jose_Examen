using Avalos_Jose_Examen.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avalos_Jose_Examen.Repository.Repositories
{
	public interface IUserRepository
	{
		IEnumerable<User> GetAll();
		User GetUser(int Id);
		int Insert(User user);
		void Delete(int id);
	}
	public class UserRepository : IUserRepository
	{
		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetAll()
		{
			throw new NotImplementedException();
		}

		public User GetUser(int Id)
		{
			throw new NotImplementedException();
		}

		public int Insert(User user)
		{
			throw new NotImplementedException();
		}
	}
}
