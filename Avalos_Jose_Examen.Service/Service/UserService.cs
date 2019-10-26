using Avalos_Jose_Examen.Model.Model;
using Avalos_Jose_Examen.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Avalos_Jose_Examen.Service.Service
{
	public interface  IUserService
	{
		IEnumerable<User> GetUsers();
		Task<User> Get(int id);
		void AddUser(User user);
		Task<User> UpdateUser(User user);
		int Delete(int id);
		
		
	}

	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;
		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
		public IEnumerable<User> GetUsers()
		{
			return _userRepository.GetAll();
		}
		public void AddUser(User user)
		{
			_userRepository.Insert(user);
		}

		public Task<User> Get(int id)
		{
            return _userRepository.Get(id);
        }

		public int Delete(int id)
		{
			return _userRepository.Delete(id);
		}
		public Task<User> UpdateUser(User user)
		{
			try
			{
				return _userRepository.Update(user);
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
