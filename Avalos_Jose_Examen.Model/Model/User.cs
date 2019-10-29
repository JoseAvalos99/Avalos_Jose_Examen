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
		[Required, MaxLength(100)]
		public string Name { get; set; }
		[Required, MaxLength(200)]
		public string LastName { get; set; }
		[Required, MaxLength(20)]
		public string NickName { get; set; }
		[Range(18,99)]
		public int? YearsOld { get; set; }
		[MaxLength(10)]
		public string Gender { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
	}
}
