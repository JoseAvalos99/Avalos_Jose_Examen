using Avalos_Jose_Examen.Model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avalos_Jose_Examen.Repository.Data
{
	class DataDbContext : DbContext
	{
		public DataDbContext()
		{

		}
		public DataDbContext(DbContextOptions options) : base(options)
		{

		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("user id=sa; password=uts; server=.; database= APIWeb;");
			}
		}
		public virtual DbSet<Contact> Contact { get; set; }
		public virtual DbSet<User> User { get; set; }
	}
}
