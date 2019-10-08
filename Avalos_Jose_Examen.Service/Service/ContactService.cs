using Avalos_Jose_Examen.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avalos_Jose_Examen.Service.Service
{
	public interface IContactService
	{
		List<Contact> GetContacts();
	}
	public class ContactService : IContactService
	{
		public List<Contact> GetContacts()
		{
			return new List<Contact>()
			{
				new Contact()
				{
					Id = 1,
					Name = "Joss",
					Mesagge= "asdasdasdasd"
				},
				new Contact()
				{
					Id= 2, 
					Name= "Jess",
					Mesagge= "dsadsadsadsadsadsa"
				}
			};
		}
	}
}
