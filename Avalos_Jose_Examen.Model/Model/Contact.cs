using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Avalos_Jose_Examen.Model.Model
{
	public class Contact : Entity
	{
		[Required]
		public string Name { get; set; }
		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required]
		public string Mesagge { get; set; }
		[Required]
		public string Subject { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public DateTime CreateDate { get; set; }
	}
}
