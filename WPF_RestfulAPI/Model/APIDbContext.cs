using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WPF_RestfulAPI.Model
{
	public class APIDbContext : DbContext
	{
		public APIDbContext(DbContextOptions<APIDbContext> options)
			: base(options)
		{
		}

		public DbSet<Person> Persons { get; set; }
		public DbSet<Position> Positions { get; set; }		
		public DbSet<Salary> Salaries { get; set; }		
		public DbSet<Department> Departments { get; set; }		
		public DbSet<PersonDetail> PersonDetails { get; set; }
	}
}
