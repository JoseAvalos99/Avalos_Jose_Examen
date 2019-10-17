using Avalos_Jose_Examen.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Avalos_Jose_Examen.Model.Model
{
	public class User 
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public string NickName { get; set; }
		public int YearsOld { get; set; }
		public GenderEnum Gender { get; set; }
		public string PhoneNumber { get; set; }
	}
}
