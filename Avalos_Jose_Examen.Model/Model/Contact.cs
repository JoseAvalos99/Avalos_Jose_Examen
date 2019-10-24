using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Avalos_Jose_Examen.Model.Model
{
	public class Contact 
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		[DataType(DataType.EmailAddress)]
		[MaxLength(100)]
		public string Email { get; set; }
		[Required]
		public string Mesagge { get; set; }
		[Required]
		[MaxLength(100)]
		public string Subject { get; set; }
		[Required]
		[MaxLength(20)]
		public string PhoneNumber { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public DateTime CreateDate { get; set; }
	}
}
