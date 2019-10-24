using Avalos_Jose_Examen.Model.Model;
using Avalos_Jose_Examen.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avalos_Jose_Examen.Repository.Repositories
{
	public interface IUserRepository
	{
		IEnumerable<User> GetAll();
		User Get(int Id);
		int Insert(User user);
		void Delete(int id);
	}
	public class UserRepository : IUserRepository
	{
		private readonly DataDbContext _db = new DataDbContext();
		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetAll()
		{
			return _db.User;
		}

		public User Get(int Id)
		{
			//return _db.User.FirstAsync(x => x.Id == Id);
			throw new NotImplementedException();
		}

		public int Insert(User user)
		{
			try
			{
				_db.Add(user);
				_db.SaveChanges();
				return 1;
			}
			catch (Exception e)
			{
				return 0;
				
			}
			//throw new NotImplementedException();
		}
	}
}
