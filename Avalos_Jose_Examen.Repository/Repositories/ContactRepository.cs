using Avalos_Jose_Examen.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avalos_Jose_Examen.Repository.Repositories
{
	public interface IContactRepository
	{
		IEnumerable<Contact> GetAll();
		Contact Get(int Id);
		int Insert(Contact contact);
		void Delete(int Id);
	}
	public class ContactRepository : IContactRepository
	{
		public void Delete(int Id)
		{
			throw new NotImplementedException();
		}

		public Contact Get(int Id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Contact> GetAll()
		{
			throw new NotImplementedException();
		}

		public int Insert(Contact contact)
		{
			throw new NotImplementedException();
		}
	}
}
