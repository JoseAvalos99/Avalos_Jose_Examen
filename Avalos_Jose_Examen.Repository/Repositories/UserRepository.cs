using Avalos_Jose_Examen.Model.Model;
using Avalos_Jose_Examen.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Avalos_Jose_Examen.Repository.Repositories
{
	public interface IUserRepository
	{
		IEnumerable<User> GetAll();
		Task<User> Get(int Id);
		int Insert(User user);
		int Delete(int id);
		Task<User> Update(User user, int Id);
	}
	public class UserRepository : IUserRepository
	{
		private readonly DataDbContext _db = new DataDbContext();
		public int Delete(int id)
		{
			
			try
			{
				User user = new User();
				Task<User> userTask = _db.User.FirstOrDefaultAsync(x => x.Id == id);
				user = userTask.Result;
				_db.User.Remove(user);
				_db.SaveChanges();
				return 1;
			}
			catch (Exception e)
			{
				return 0;
			}
		}

		public IEnumerable<User> GetAll()
		{
			return _db.User;
		}

		public Task<User> Get(int Id)
		{
			return _db.User.FirstOrDefaultAsync(x => x.Id == Id);
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
		}

		public Task<User> Update(User user)
		{
			try
			{
				
			}
			catch (Exception)
			{

				throw;
			}
			
		}
	}
}
