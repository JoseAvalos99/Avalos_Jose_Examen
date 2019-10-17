using Avalos_Jose_Examen.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avalos_Jose_Examen.Service.Service
{
	public interface IContactService
	{
		
		List<Contact> GetAll();
		Contact GetContactById(int Id);
		List<Contact> Insert(Contact contact);
		List<Contact> Update(int Id, Contact contact);
	}
	public class ContactService : IContactService
	{
		List<Contact> contacts = new List<Contact>()
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
		//public IEnumerable<Contact> GetAll()
		//{
		//	return null;
		//}
		public List<Contact> GetAll()
		{
			return contacts;
		}
		public Contact GetContactById(int Id)
		{
			Contact contactFiltered = contacts.Where(x => x.Id == Id).FirstOrDefault();
			return contactFiltered;
		}

		public List<Contact> Insert(Contact contact)
		{
			contacts.Add(contact);
			return contacts;
		}

		public List<Contact> Update(int Id,Contact contact)
		{
			foreach(Contact c in contacts.FindAll(c => c.Id== Id))
			{
				c.Name = contact.Name;
				c.Email = contact.Email;
				c.Mesagge = contact.Mesagge;
				c.Subject = contact.Subject;
				c.PhoneNumber = contact.PhoneNumber;
				c.CreateDate = contact.CreateDate;
			}
			return contacts;
		}
	}
}
