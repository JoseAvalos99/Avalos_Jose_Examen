using Avalos_Jose_Examen.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avalos_Jose_Examen.Service.Service
{
	public interface  IUserService
	{
		List<User> GetUsers();
	}

	public class UserService : IUserService
	{
		public List<User> GetUsers()
		{
			return new List<User>()
			{
				new User()
				{
					Id = 1,
					Name = "Joss",
					LastName = "Leal",
					NickName = "Oreos",
					Gender = Model.Enums.GenderEnum.NonBinary,
					PhoneNumber = "6441221122",
					YearsOld = 20
				}
			};
		}
	}
}
