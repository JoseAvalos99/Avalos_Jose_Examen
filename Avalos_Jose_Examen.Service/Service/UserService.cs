using Avalos_Jose_Examen.Model.Model;
using Avalos_Jose_Examen.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avalos_Jose_Examen.Service.Service
{
	public interface  IUserService
	{
		List<User> GetUsers();
		void AddUser(User user);
		
	}

	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;
		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
		public List<User> GetUsers()
		{
			return new List<User>()
			{
				new User()
				{
					Id = 1,
					Name = "Oreos",
					LastName = "Leal",
					NickName = "Oreos",
					Gender = Model.Enums.GenderEnum.NonBinary,
					PhoneNumber = "6441221122",
					YearsOld = 20
				},
				new User()
				{
					Id = 2,
					Name = "Mecury",
					LastName = "Sama",
					NickName = "Dark Flame Master",
					Gender = Model.Enums.GenderEnum.Male,
					PhoneNumber = "6441221111",
					YearsOld = 21
				},
				new User()
				{
					Id = 3,
					Name = "Jotaro",
					LastName = "Kujo",
					NickName = "Star Platinum",
					Gender = Model.Enums.GenderEnum.Male,
					PhoneNumber = "6441221133",
					YearsOld = 17
				}
			};
		}
		public void AddUser(User user)
		{
			_userRepository.Insert(user);
		}
	}
}
